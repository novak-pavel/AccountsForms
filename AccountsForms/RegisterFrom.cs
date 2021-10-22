using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsForms
{
    public partial class RegisterFrom : Form
    {
        private AccountManager _manager;
        public RegisterFrom(AccountManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }
        private void _btnCancel_Click(object sender, EventArgs e)
        {

        }
        private void _btnRegister_Click(object sender, EventArgs e)
        {
            if(_txtPassword.Text == _txtCheckPassword.Text && _txtPassword.Text.Length >= 6)
            {
                _manager.Register(new Models.UserModel()
                {
                    Id = Guid.NewGuid(),
                    Name = _txtName.Text,
                    Surname = _txtSurname.Text,
                });
            }
        }
    }
}
