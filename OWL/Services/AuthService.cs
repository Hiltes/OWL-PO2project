using OWL.Models;
using Npgsql;
using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using OWL.Data;

namespace OWL.Services
{
    public class AuthService
    {
        private readonly OwlDbContext _context;
        private readonly string _superConnectionString;

        public AuthService()
        {
            _context = new OwlDbContext();

            var configuration = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName)
                .AddJsonFile("appsettings.json")
                .Build();

            _superConnectionString = configuration.GetConnectionString("OwlDatabase");
        }


        public bool RegisterUser(string username, string email, string password)
        {
            if (_context.Users.Any(u => u.Username == username || u.Email == email))
                return false;

            var user = new User
            {
                Username = username,
                Email = email
            };

            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx)
            {
                Console.WriteLine($"[ERROR] DbUpdateException przy SaveChanges(): {dbEx.Message}");

                if (dbEx.InnerException != null)
                {
                    Console.WriteLine($"[ERROR] InnerException: {dbEx.InnerException.Message}");

                    if (dbEx.InnerException is Npgsql.PostgresException pgEx)
                    {
                        Console.WriteLine($"[ERROR] PostgreSQL SqlState: {pgEx.SqlState}");
                        Console.WriteLine($"[ERROR] PostgreSQL Detail: {pgEx.Detail}");
                        Console.WriteLine($"[ERROR] PostgreSQL Hint: {pgEx.Hint}");
                    }
                }

                return false;
            }

            try
            {
                using (var conn = new NpgsqlConnection(_superConnectionString))
                {
                    conn.Open();

                    string createRole =
                        $"CREATE ROLE \"{username}\" WITH LOGIN PASSWORD '{password}';";

                    string grantPrivileges =
                        $"GRANT CONNECT ON DATABASE \"owl_db\" TO \"{username}\";\n" +
                        $"GRANT USAGE ON SCHEMA public TO \"{username}\";\n" +
                        $"GRANT SELECT, INSERT, UPDATE, DELETE ON ALL TABLES IN SCHEMA public TO \"{username}\";\n" +
                        $"ALTER DEFAULT PRIVILEGES IN SCHEMA public " +
                        $"GRANT SELECT, INSERT, UPDATE, DELETE ON TABLES TO \"{username}\";";

                    try
                    {
                        using var cmd = new NpgsqlCommand(createRole, conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Npgsql.PostgresException pgEx)
                    {
                        Console.WriteLine($"[ERROR] Błąd CREATE ROLE: {pgEx.Message}");
                        Console.WriteLine($"[ERROR] SqlState: {pgEx.SqlState}");
                        Console.WriteLine($"[ERROR] Detail: {pgEx.Detail}");
                        Console.WriteLine($"[ERROR] Hint: {pgEx.Hint}");

                        var inserted = _context.Users.FirstOrDefault(u => u.Username == username);
                        if (inserted != null)
                        {
                            _context.Users.Remove(inserted);
                            _context.SaveChanges();
                        }
                        return false;
                    }

                    try
                    {
                        using var cmd2 = new NpgsqlCommand(grantPrivileges, conn);
                        cmd2.ExecuteNonQuery();
                    }
                    catch (Npgsql.PostgresException pgEx)
                    {
                        Console.WriteLine($"[ERROR] Błąd GRANT: {pgEx.Message}");
                        Console.WriteLine($"[ERROR] SqlState: {pgEx.SqlState}");
                        Console.WriteLine($"[ERROR] Detail: {pgEx.Detail}");
                        Console.WriteLine($"[ERROR] Hint: {pgEx.Hint}");

                        using (var rollbackConn = new NpgsqlConnection(_superConnectionString))
                        {
                            rollbackConn.Open();
                            using var dropCmd = new NpgsqlCommand($"DROP ROLE IF EXISTS \"{username}\";", rollbackConn);
                            dropCmd.ExecuteNonQuery();
                        }
                        var inserted = _context.Users.FirstOrDefault(u => u.Username == username);
                        if (inserted != null)
                        {
                            _context.Users.Remove(inserted);
                            _context.SaveChanges();
                        }
                        return false;
                    }

                    conn.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Niespodziewany wyjątek przy tworzeniu roli: {ex.Message}");
                return false;
            }
        }

        public bool LoginUser(string username, string password)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                    return false;

                var builder = new NpgsqlConnectionStringBuilder(_superConnectionString)
                {
                    Username = username,
                    Password = password
                };

                using var conn = new NpgsqlConnection(builder.ConnectionString);
                try
                {
                    conn.Open(); 
                    conn.Close();
                    return true;
                }
                catch (Npgsql.PostgresException pgEx)
                {
                    Console.WriteLine($"[ERROR] Błąd logowania (PostgresException): {pgEx.Message}");
                    Console.WriteLine($"[ERROR] SqlState: {pgEx.SqlState}");
                    Console.WriteLine($"[ERROR] Detail: {pgEx.Detail}");
                    Console.WriteLine($"[ERROR] Hint: {pgEx.Hint}");
                    return false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"[ERROR] Błąd logowania (inne): {ex.Message}");
                return false;
            }
        }


        public bool CheckUser(string username)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == username);
                return user != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd sprawdzania użytkownika: {ex.Message}");
                return false;
            }
        }

        public User GetUser(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
