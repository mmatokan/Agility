using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agility.DomainModel;
using Agility.BaseLib;

//TODO add to _selectedMembers
namespace Agility.PresentationLayer
{
    public partial class frmCreateProject : Form, IAddNewProjectView
    {
        private readonly List<User> _users = null;
        private readonly Project _project = null;

        public frmCreateProject(List<User> inUsers, string inTitle, Project inProject)
        {
            _users = inUsers;
            _project = inProject;

            InitializeComponent();
            lblFormTitle.Text = inTitle;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void PopulateFields()
        {
            textBoxTitle.Text = _project.Name;
            textBoxDescription.Text = _project.Description;
            dateStart.Value = _project.StartDate;
            dateEnd.Value = _project.EndDate;
            foreach (User u in _project.Members)
            {
                selectMembersList.SelectedIndex = selectMembersList.FindString(u.FullName);
            }
        }


        public string ProjectDescription => textBoxDescription.Text;

        public DateTime ProjectStartDate => dateStart.Value;

        public DateTime ProjectEndDate => dateEnd.Value;

        public List<User> ProjectMembers => selectMembersList.SelectedItems.Cast<User>().ToList();

        public string ProjectName => textBoxTitle.Text;

        public bool ShowViewModal()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void frmCreateProject_Load(object sender, EventArgs e)
        {
            selectMembersList.DataSource = _users;
            selectMembersList.DisplayMember = "FullName";
            selectMembersList.SelectionMode = SelectionMode.MultiSimple;
            selectMembersList.ClearSelected();

            if (_project != null)
            {
                PopulateFields();
            }
        }
    }
}
