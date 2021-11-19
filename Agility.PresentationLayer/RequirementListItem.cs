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
    public partial class RequirementListItem : UserControl
    {
        public RequirementListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _type;
        private string _title;
        private string _description;
        private string _status;
        private Color _highlight;

        [Category("Custom Props")]
        public string Type
        {
            get { return _type; }
            set { _type = value; lblType.Text = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lblDesc.Text = value; }
        }

        [Category("Custom Props")]
        public string Status
        {
            get { return _status; }
            set { _status = value; lblTasks.Text = value; }
        }

        [Category("Custom Props")]
        public Requirement Requirement { get; set; }

        [Category("Custom Props")]
        public IProjectViewController ProjectController { get; set; } = null;

        [Category("Custom Props")]
        public IShowProjectView ProjectView { get; set; } = null;

        [Category("Custom Props")]
        public Color Highlight
        {
            get { return _highlight; }
            set { _highlight = value; pnlPriorityColor.BackColor = value; }
        }
        #endregion

        private void requirement_DoubleClick(object sender, EventArgs e)
        {
            ProjectController.EditRequirement(Requirement);
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            ProjectController.DeleteRequirement(Requirement);
        }
    }
}
