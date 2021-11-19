using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agility.BaseLib;

namespace Agility.PresentationLayer
{
    [ToolboxItem(true)]
    public partial class TaskListItem : UserControl
    {
        public TaskListItem()
        {
            InitializeComponent();
            lblDesc.Width = pnlCenter.Width;
        }

        #region Properties
        private string _type;
        private string _description;
        private string _memberWorking;
        private Color _highlight;

        [Category("Custom Props")]
        public string Type
        {
            get { return _type; }
            set { _type = value; lblType.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lblDesc.Text = value; }
        }

        [Category("Custom Props")]
        public string MemberWorking
        {
            get { return _memberWorking; }
            set { _memberWorking = value; lblMemberWorking.Text = value; }
        }

        [Category("Custom Props")]
        public DomainModel.Task Task { get; set; }

        [Category("Custom Props")]
        public IProjectViewController ProjectController { get; set; } = null;

        [Category("Custom Props")]
        public IShowProjectView ProjectView { get; set; } = null;

        [Category("Custom Props")]
        public Color Highlight
        {
            get { return _highlight; }
            set { _highlight = value; pnlPriorityColor.BackColor = value;}
        }
        #endregion

        private void TaskListItem_MouseDown(object sender, MouseEventArgs e)
        {
            if(this.Task.MemberWorking == null || this.Task.MemberWorking.Equals(ProjectController.GetCurrentUser()))
            {
                DoDragDrop(this, DragDropEffects.All);
            }
        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }
    }

}
