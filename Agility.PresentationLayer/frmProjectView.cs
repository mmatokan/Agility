using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agility.BaseLib;

namespace Agility.PresentationLayer
{
    public partial class frmProjectView : Form, IShowProjectView
    {
        private Button _currentBtn;
        private readonly Panel _leftBorderBtn;

        private IMainFormController _mainController = null;
        private IMainFormView _mainView = null;
        private IProjectViewController _projectViewController = null;

        public Panel FormContainer => pnlFormContainer;

        public frmProjectView(IMainFormController inMainController, IMainFormView inMainForm, IProjectViewController inProjectViewController)
        {
            _mainController = inMainController;
            _mainView = inMainForm;
            _projectViewController = inProjectViewController;

            InitializeComponent();

            _leftBorderBtn = new Panel
            {
                Size = new Size(7, 50)
            };
            pnlSideMenu.Controls.Add(_leftBorderBtn);

            _projectViewController.OpenProjectDashboard(this);
            
        }

        private struct RGBColors
        {
            public static Color navigationColor = Color.FromArgb(42, 48, 64);
            public static Color navigationSelectedColor = Color.FromArgb(93, 105, 140);
            public static Color navigationHighlightColor = Color.FromArgb(135, 153, 204);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();

                _currentBtn = (Button)senderBtn;
                _currentBtn.BackColor = RGBColors.navigationSelectedColor;
                _currentBtn.ForeColor = color;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;

                _leftBorderBtn.BackColor = color;
                _leftBorderBtn.Location = new Point(0, _currentBtn.Location.Y);
                _leftBorderBtn.Visible = true;
                _leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if(_currentBtn != null)
            {
                _currentBtn.BackColor = RGBColors.navigationColor;
                _currentBtn.ForeColor = Color.White;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }
          
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.navigationHighlightColor);
            _mainController.OpenHomePage(_mainView);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.navigationHighlightColor);
            _projectViewController.OpenProjectDashboard(this);

        }

        private void btnBacklog_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.navigationHighlightColor);
            _projectViewController.OpenProjectBacklog(this);
        }

        private void btnSprint_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.navigationHighlightColor);
            _projectViewController.OpenProjectSprint(this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.navigationHighlightColor);
            _mainController.OpenLoginForm(_mainView);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pnlFormContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
