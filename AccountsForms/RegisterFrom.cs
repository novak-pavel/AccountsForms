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
            Close();
        }
        private void _btnRegister_Click(object sender, EventArgs e)
        {
            if(_txtPassword.Text == _txtCheckPassword.Text && _txtPassword.Text.Length >= 6)
            {
                var result = _manager.Register(new Models.UserModel()
                {
                    Id = Guid.NewGuid(),
                    Name = _txtName.Text,
                    Surname = _txtSurname.Text,
                    Password = _txtPassword.Text,
                    UserName = _txtUsername.Text
                });

                if (result)
                {
                    Close();
                }
            }
            else if(_txtPassword != _txtCheckPassword)
            {
                MessageBox.Show("Hesla se neshodují");
            }
            else
            {
                MessageBox.Show("Heslo je příliš krátké");
            }
        }
    }
}
