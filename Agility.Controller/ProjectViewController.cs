using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Agility.BaseLib;
using Agility.DomainModel;

namespace Agility.Controller
{
    public class ProjectViewController : IProjectViewController
    {
        private readonly IWindowsFormsFactory _formsFactory = null;
        private Form _currentChildForm;
        private IBacklogController _backlogController;
        private ISprintController _sprintController;

        public ProjectViewController(IWindowsFormsFactory inFormFactory, IBacklogController inBacklogController, ISprintController inSprintController)
        {
            _formsFactory = inFormFactory;
            _backlogController = inBacklogController;
            _sprintController = inSprintController;
        }

        public void OpenChildForm(IShowProjectView mainForm, Form childForm)
        {
            if (childForm != null)
            {
                //first close any open children forms
                if (_currentChildForm != null)
                {
                    _currentChildForm.Close();
                }
                _currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                mainForm.FormContainer.Controls.Add(childForm);
                mainForm.FormContainer.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }

        }

        public bool AddRequirement()
        {
            List<string> types = RequirementType.DesToType.Keys.Cast<string>().ToList();
            List<string> priorities = RequirementPriority.DesToPrority.Keys.Cast<string>().ToList();
            var newFrm = _formsFactory.CreateAddNewRequirementView(types, priorities, "Add new requirement", null);
            return _backlogController.AddNewRequirement(newFrm);
        }

        public void EditRequirement(Requirement requirement)
        {
            List<string> types = RequirementType.DesToType.Keys.Cast<string>().ToList();
            List<string> priorities = RequirementPriority.DesToPrority.Keys.Cast<string>().ToList();
            var newFrm = _formsFactory.CreateAddNewRequirementView(types, priorities, "Edit requirement \"" + requirement.Title + "\"", requirement);
            _backlogController.EditRequirement(newFrm, requirement);
        }

        public void DeleteRequirement(Requirement requirement)
        {
            _backlogController.DeleteRequirement(requirement);
        }

        public bool AddSprint()
        {
            List<Task> backlogTasks = _backlogController.GetAllBacklogTasks();
            var newForm = _formsFactory.CreateAddNewSprintView(backlogTasks);
            return _sprintController.AddNewSprint(newForm);
        }

        public void OpenProjectBacklog(IShowProjectView projectView)
        {
            var newFrm = _formsFactory.CreateShowBacklogView(this, projectView, _backlogController);
            OpenChildForm(projectView, (Form)newFrm);
        }

        public void OpenProjectDashboard(IShowProjectView projectView)
        {
            IDashboardController _dashboardController = new DashboardController(_backlogController);
            var newFrm = _formsFactory.CreateShowProjectDashboardView(this, projectView, _dashboardController);
            OpenChildForm(projectView, (Form)newFrm);
        }

        public void OpenProjectSprint(IShowProjectView projectView)
        {
            var newFrm = _formsFactory.CreateShowSprintView(this, projectView, _sprintController);
            OpenChildForm(projectView, (Form)newFrm);
        }

        public User GetCurrentUser()
        {
            return GlobalInfo.CurrentUser;
        }
    }
}
