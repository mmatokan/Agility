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

namespace Agility.PresentationLayer
{
    public partial class frmCreateSprint : Form, IAddNewSprintView
    {
        private readonly List<DomainModel.Task> _projectTasks = null;

        public frmCreateSprint(List<DomainModel.Task> inProjectTasks)
        {
            _projectTasks = inProjectTasks;

            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public string SprintTitle => textBoxTitle.Text;

        public DateTime SprintStartDate => dateStart.Value;

        public DateTime SprintEndDate => dateEnd.Value;

        public List<DomainModel.Task> SprintTasks => selectTasksList.SelectedItems.Cast<DomainModel.Task>().ToList();

        public bool ShowViewModal()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void frmCreateSprint_Load(object sender, EventArgs e)
        {
            selectTasksList.DataSource = _projectTasks;
            selectTasksList.DisplayMember = "Description";
            selectTasksList.SelectionMode = SelectionMode.MultiSimple;
        }
    }
}
