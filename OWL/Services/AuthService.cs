using OWL.Models; 
using System.Linq;

namespace OWL.Services
{
    public class AuthService
    {
        private readonly OwlDbContext _context;

        public AuthService()
        {
            _context = new OwlDbContext(); 
        }

        public bool RegisterUser(string username, string email, string password)
        {
            if (_context.Users.Any(u => u.Username == username || u.Email == email))
                return false;

            var user = new User
            {
                Username = username,
                Email = email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password)
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public bool LoginUser(string username, string password)

        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == username);
                if (user == null) return false;

                return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd logowania: {ex.Message}");
                return false;
            }
        }



        public bool CheckUser(string username)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == username);
                if (user == null) return false;

                return true;
            }catch (Exception ex)
            {
                Console.WriteLine($"Błąd logowania: {ex.Message}");
                return false;
            }
        }

        public User GetUser(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}