using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agility.BaseLib;

namespace Agility.PresentationLayer
{
    public partial class frmLogIn : Form, ILoginUserView
    {
        private IMainFormController _mainController = null;
        private IMainFormView _mainView = null;
        public frmLogIn(IMainFormController inMainController, IMainFormView inMainForm)
        {
            _mainController = inMainController;
            _mainView = inMainForm;

            InitializeComponent();
            this.Text = "Log in";
        }

        public string Email => textBoxEmail.Text;

        public string Password => textBoxPassword.Text;

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            _mainController.OpenSignUpForm(_mainView);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = _mainController.LoginUser(this);
            if (success)
            {
                _mainController.OpenHomePage(_mainView);
            }
        }
    }
}
