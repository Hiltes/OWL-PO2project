using OWL.Models;
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
                if (user == null) return false;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd logowania: {ex.Message}");
                return false;
            }
        }



    }
}