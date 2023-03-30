using Azure.Identity;

namespace BlazorServer.Data
{
    public class LoginState
    {
        public bool IsLoggedIn { get; set; }
        public string username { get; set; }
        public event Action onchange;

        public void SetLogin (bool login, string user)
        {
            IsLoggedIn = login;
            username = user;
            NotifyStateChanged();
        }

        private void NotifyStateChanged ()
        {
            onchange?.Invoke ();
        }
    }
}
