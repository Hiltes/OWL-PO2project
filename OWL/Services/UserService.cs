using OWL.Data;
using System;
using System.Linq;

namespace OWL.Services
{
    public class UserService
    {
        private readonly OwlDbContext _context;

        public UserService()
        {
            _context = new OwlDbContext();
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
    }
}
