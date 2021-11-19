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
using Agility.DomainModel;

namespace Agility.PresentationLayer
{
    public partial class FrmHomeView : Form, IHomeView
    {
        private Button _currentBtn;
        private readonly Panel _leftBorderBtn;

        private List<Project> _listProjects = null;
        private IMainFormController _mainController = null;
        private IMainFormView _mainView = null;
        private IProjectController _projectController = null;

        public FrmHomeView(IMainFormController inMainController, IMainFormView inMainForm, IProjectController inProjectController)
        {
            _mainController = inMainController;
            _mainView = inMainForm;
            _projectController = inProjectController;
            _projectController.Attach(this);
            _listProjects = _projectController.GetAllUsersProjects();

            InitializeComponent();

            _leftBorderBtn = new Panel
            {
                Size = new Size(7, 50)
            };
            pnlSideMenu.Controls.Add(_leftBorderBtn);

            this.DoubleBuffered = true;

            ShowListOfProjects();
        }
        private struct RGBColors
        {
            public static Color navigationColor = Color.FromArgb(42, 48, 64);
            public static Color navigationSelectedColor = Color.FromArgb(93, 105, 140);
            public static Color navigationHighlightColor = Color.FromArgb(135, 153, 204);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
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
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = RGBColors.navigationColor;
                _currentBtn.ForeColor = Color.White;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.navigationHighlightColor);
            _mainController.AddProject();
            DisableButton();
        }
        
        private void frmProjectSelection_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.navigationHighlightColor);
            _mainController.OpenLoginForm(_mainView);
        }

        void IObserver.Update()
        {
            _listProjects = _projectController.GetAllUsersProjects();
            ShowListOfProjects();
        }

        public void ShowListOfProjects()
        {
            flowLayoutPanelProjects.Controls.Clear();
            foreach (Project p in _listProjects)
            {
                ProjectListItem item = new ProjectListItem();
                item.Title = p.Name;
                int daysLeft = (p.EndDate - DateTime.Now).Days;
                if (daysLeft < 1)
                {
                    item.Status = "Finished";
                }
                else if (daysLeft == 1)
                {
                    item.Status = "1 day left";

                }
                else
                {
                    item.Status = daysLeft.ToString() + " days left";
                }
                item.Project = p;
                item.MainController = _mainController;
                item.MainView = _mainView;
                flowLayoutPanelProjects.Controls.Add(item);
            }
        }
    }
}
