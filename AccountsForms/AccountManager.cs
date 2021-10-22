using AccountsForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsForms
{
    class AccountManager
    {
        private List<UserModel> _users;

        public AccountManager()
        {
            _users = new List<UserModel>();
        }
    }
}
