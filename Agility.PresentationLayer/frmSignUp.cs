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
    public partial class frmSignUp : Form, ISignUpUserView
    {
        private IMainFormController _mainController = null;
        private IMainFormView _mainView = null;

        public frmSignUp(IMainFormController inMainController, IMainFormView inMainForm)
        {
            _mainController = inMainController;
            _mainView = inMainForm;

            InitializeComponent();
            this.Text = "Sign up";
        }
        public string SingUpName => textBoxName.Text;

        public string SignUpSurname => textBoxSurname.Text;

        public string SignUpEmail => textBoxEmail.Text;

        public string SignUpPassword => textBoxPassword.Text;

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool success = _mainController.SignUpUser(this);
            if (success)
            {
                _mainController.OpenHomePage(_mainView);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainController.OpenLoginForm(_mainView);
        }

    }
}
