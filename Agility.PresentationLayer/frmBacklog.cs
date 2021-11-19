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
    public partial class frmBacklog : Form, IShowBacklogView
    {
        private List<Requirement> _listRequirements = null;
        private IProjectViewController _projectViewController = null;
        private IShowProjectView _projectView = null;
        private IBacklogController _backlogController = null;
        public frmBacklog(IProjectViewController inProjectViewController, IShowProjectView inProjectView, IBacklogController inBacklogController)
        {
            _projectView = inProjectView;
            _projectViewController = inProjectViewController;
            _backlogController = inBacklogController;
            _backlogController.Attach(this);
            _listRequirements = _backlogController.GetRequirements();
            InitializeComponent();

            ShowListOfRequirements();
        }
        
        private void frmBacklog_Load(object sender, EventArgs e)
        {
        }

        private void btnAddRequirement_Click(object sender, EventArgs e)
        {
            _projectViewController.AddRequirement();
        }

        public void ShowListOfRequirements()
        {
            tableReqs.Controls.Clear();
            int i = 0;
            int j = 0;
            int k = 0;
            foreach (Requirement r in _listRequirements)
            {

                RequirementListItem item = new RequirementListItem();
                item.Type = RequirementType.TypeToDesc[r.Type];
                item.Title = r.Title;
                item.Description = r.Description;
                int count = r.RequirementTasks.Count();
                if (count == 1)
                {
                    item.Status = "1 task left";
                }
                else
                {
                    item.Status = count.ToString() + " tasks left";
                }
                item.Requirement = r;
                item.ProjectController = _projectViewController;
                item.ProjectView = _projectView;
                item.Dock = DockStyle.Fill;
                switch (r.Priority)
                {
                    case RequirementPriority.PriorityEnum.HIGH:
                        item.Highlight = Color.Maroon;
                        tableReqs.Controls.Add(item, 0, i);
                        i++;
                        break;
                    case RequirementPriority.PriorityEnum.MEDIUM:
                        item.Highlight = Color.Goldenrod;
                        tableReqs.Controls.Add(item, 1, j);
                        j++;
                        break;
                    case RequirementPriority.PriorityEnum.LOW:
                        item.Highlight = Color.ForestGreen;
                        tableReqs.Controls.Add(item, 2, k);
                        k++;
                        break;
                    default:
                        break;
                }

            }
        }

        void IObserver.Update()
        {
            _listRequirements = _backlogController.GetRequirements();
            ShowListOfRequirements();
        }
    }
}
