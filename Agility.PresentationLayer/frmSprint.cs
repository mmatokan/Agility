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
    public partial class frmSprint : Form, IShowSprintView
    {
        private List<DomainModel.Task> _sprintTasks = null;
        private IProjectViewController _projectViewController = null;
        private IShowProjectView _projectView = null;
        private ISprintController _sprintController = null;
        public frmSprint(IProjectViewController inProjectViewController, IShowProjectView inProjectView, ISprintController inSprintController)
        {
            _projectView = inProjectView;
            _projectViewController = inProjectViewController;
            _sprintController = inSprintController;
            _sprintController.Attach(this);
            _sprintTasks = _sprintController.GetSprintTask();
            InitializeComponent();
            
            if(_sprintTasks != null)
            {
                pnlAddSprint.Visible = false;
                pnlSprint.Visible = true;
                ShowListOfTasks();
            }
            else
            {
                pnlAddSprint.Visible = true;
                pnlSprint.Visible = false;
            }

            lblDate.Text = _sprintController.GetFormatedStartDate() + " - " + _sprintController.GetFormatedEndDate();
            
        }

        public void ShowListOfTasks()
        {
            flowToDo.SuspendLayout();
            flowInProgress.SuspendLayout();
            flowStuck.SuspendLayout();
            flowDone.SuspendLayout();
            flowToDo.Controls.Clear();
            flowInProgress.Controls.Clear();
            flowStuck.Controls.Clear();
            flowDone.Controls.Clear();
            int i = 0;
            int j = 0;
            int k = 0;
            int m = 0;
            foreach (DomainModel.Task t in _sprintTasks)
            {
                TaskListItem item = new TaskListItem();
                item.Type = RequirementType.TypeToDesc[t.Requirement.Type];
                item.Description = t.Description;
                if(t.MemberWorking != null)
                {
                    item.MemberWorking = t.MemberWorking.FullName;
                }
                else
                {
                    item.MemberWorking = "";
                }
                item.Task = t;
                item.ProjectController = _projectViewController;
                item.ProjectView = _projectView;
                switch (t.Status)
                {
                    case DomainModel.TaskStatus.StatusEnum.TO_DO:
                        item.Highlight = Color.DodgerBlue;
                        item.Width = flowToDo.Width;
                        flowToDo.Controls.Add(item);
                        i++;
                        break;
                    case DomainModel.TaskStatus.StatusEnum.IN_PROGRESS:
                        item.Highlight = Color.LightSeaGreen;
                        item.Width = flowInProgress.Width;
                        flowInProgress.Controls.Add(item);
                        j++;
                        break;
                    case DomainModel.TaskStatus.StatusEnum.STUCK:
                        item.Highlight = Color.MediumTurquoise;
                        item.Width = flowStuck.Width;
                        flowStuck.Controls.Add(item);
                        k++;
                        break;
                    case DomainModel.TaskStatus.StatusEnum.DONE:
                        item.Highlight = Color.PaleTurquoise;
                        item.Width = flowDone.Width;
                        flowDone.Controls.Add(item);
                        m++;
                        break;
                    default:
                        break;
                
                }

            }
            flowToDo.ResumeLayout();
            flowInProgress.ResumeLayout();
            flowStuck.ResumeLayout();
            flowDone.ResumeLayout();

            lblNumOfToDo.Text = "Total: " + i.ToString();
            lblNumOfInProgress.Text = "Total: " + j.ToString();
            lblNumOfStuck.Text = "Total: " + k.ToString();
            lblNumOfDone.Text = "Total: " + m.ToString();

        }

        private void frmSprint_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddSprint_Click(object sender, EventArgs e)
        {
            _projectViewController.AddSprint();
        }

        void IObserver.Update()
        {
            _sprintTasks = _sprintController.GetSprintTask();
            
            if (_sprintTasks != null)
            {
                pnlAddSprint.Visible = false;
                pnlSprint.Visible = true;
                ShowListOfTasks();
            }
            else
            {
                pnlAddSprint.Visible = true;
                pnlSprint.Visible = false;
            }
            
        }

        #region Drag and drop controlls
        private void flowToDo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskListItem)))
            {
                e.Effect = DragDropEffects.All;
            }
            flowToDo.BackColor = Color.FromArgb(143, 163, 217);
        }

        private void flowToDo_DragDrop(object sender, DragEventArgs e)
        {
            TaskListItem tli = ((TaskListItem)e.Data.GetData(typeof(TaskListItem)));
            tli.BringToFront();
            if(tli.Task.Status != DomainModel.TaskStatus.StatusEnum.TO_DO)
            {
                _sprintController.UpdateTask(tli.Task, DomainModel.TaskStatus.StatusEnum.TO_DO);
            }
            flowToDo.BackColor = Color.FromArgb(50, 57, 77); 
        }

        private void flowInProgress_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskListItem)))
            {
                e.Effect = DragDropEffects.All;
            }
            flowInProgress.BackColor = Color.FromArgb(143, 163, 217);
        }

        private void flowInProgress_DragDrop(object sender, DragEventArgs e)
        {
            TaskListItem tli = ((TaskListItem)e.Data.GetData(typeof(TaskListItem)));
            tli.BringToFront();
            if(tli.Task.Status != DomainModel.TaskStatus.StatusEnum.IN_PROGRESS)
            {
                _sprintController.UpdateTask(tli.Task, DomainModel.TaskStatus.StatusEnum.IN_PROGRESS);
            }
            flowInProgress.BackColor = Color.FromArgb(50, 57, 77); 
        }

        private void flowStuck_DragDrop(object sender, DragEventArgs e)
        {
            TaskListItem tli = ((TaskListItem)e.Data.GetData(typeof(TaskListItem)));
            tli.BringToFront();
            if(tli.Task.Status != DomainModel.TaskStatus.StatusEnum.STUCK)
            {
                _sprintController.UpdateTask(tli.Task, DomainModel.TaskStatus.StatusEnum.STUCK);
            }
            flowStuck.BackColor = Color.FromArgb(50, 57, 77);
        }

        private void flowStuck_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskListItem)))
            {
                e.Effect = DragDropEffects.All;
            }
            flowStuck.BackColor = Color.FromArgb(143, 163, 217);
        }

        private void flowDone_DragDrop(object sender, DragEventArgs e)
        {
            TaskListItem tli = ((TaskListItem)e.Data.GetData(typeof(TaskListItem)));
            tli.BringToFront();
            if(tli.Task.Status != DomainModel.TaskStatus.StatusEnum.DONE)
            {
                _sprintController.UpdateTask(tli.Task, DomainModel.TaskStatus.StatusEnum.DONE);
            }
            flowDone.BackColor = Color.FromArgb(50, 57, 77);
        }

        private void flowDone_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskListItem)))
            {
                e.Effect = DragDropEffects.All;
            }
            flowDone.BackColor = Color.FromArgb(143,163,217);
        }

        private void flowDone_DragLeave(object sender, EventArgs e)
        {
            flowDone.BackColor = Color.FromArgb(50, 57, 77);
        }

        private void flowStuck_DragLeave(object sender, EventArgs e)
        {
            flowStuck.BackColor = Color.FromArgb(50, 57, 77);
        }

        private void flowInProgress_DragLeave(object sender, EventArgs e)
        {
            flowInProgress.BackColor = Color.FromArgb(50, 57, 77);
        }

        private void flowToDo_DragLeave(object sender, EventArgs e)
        {
            flowToDo.BackColor = Color.FromArgb(50, 57, 77);
        }
        #endregion
    }
}
