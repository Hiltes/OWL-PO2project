using OWL.Models;
using OWL.Services;

namespace OWL.Services
{
    public class Session
    {
        private static Session? _instance;
        public static Session Instance => _instance ??= new Session();

        public User? CurrentUser { get; private set; }

        private Session() { }

        public void Login(string username)
        {
            var authService = new AuthService();
            var user = authService.GetUser(username);

            if (user != null)
                CurrentUser = user;
        }

        public User GetLocalUser()
        {
            var user = CurrentUser;
            return user;
        }


        public void Logout()
        {
            CurrentUser = null;
        }

        public bool IsLoggedIn => CurrentUser != null;
    }
}
