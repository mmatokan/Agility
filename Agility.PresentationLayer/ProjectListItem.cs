using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agility.DomainModel;
using Agility.BaseLib;

namespace Agility.PresentationLayer
{
    [ToolboxItem(true)]
    public partial class ProjectListItem : UserControl
    {
        public ProjectListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _title;
        private string _status;
        private Project _project;
        private IMainFormController _mainController = null;
        private IMainFormView _mainView = null;

        [Category("Custom Props")]
        public string Title 
        { 
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Status
        {
            get { return _status; }
            set { _status = value; lblStatus.Text = value; }
        }

        [Category("Custom Props")]
        public Project Project
        {
            get { return _project; }
            set { _project = value; }
        }

        [Category("Custom Props")]
        public IMainFormController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        [Category("Custom Props")]
        public IMainFormView MainView
        {
            get { return _mainView; }
            set { _mainView = value; }
        }
        #endregion

        private void ProjectListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(34, 38, 51);
            this.lblStatus.ForeColor = Color.White;
            this.lblTitle.ForeColor = Color.White;
        }

        private void ProjectListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(143, 163, 217);
            this.lblStatus.ForeColor = Color.Black;
            this.lblTitle.ForeColor = Color.Black;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            _mainController.OpenProjectView(_mainView, _project);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _mainController.DeleteProject(_project);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _mainController.ExitProject(_project);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _mainController.EditProject(_mainView, _project);
        }
    }
}
