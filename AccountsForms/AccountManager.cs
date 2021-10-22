using AccountsForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsForms
{
    public class AccountManager
    {
        private List<UserModel> _users;

        public AccountManager()
        {
            _users = new List<UserModel>();
        }

        public bool Register(UserModel model)
        {
            return false;
        }

        public UserModel User { private set; get; }

        public bool Login()
        {
            return false;
        }

        private void Logout()
        {

        }
    }
}
