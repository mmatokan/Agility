using Agility.BaseLib;
using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Agility.Controller
{
    public class MainFormController : IMainFormController
    {
        private readonly IWindowsFormsFactory _formsFactory = null;
        private IUserController _userController;
        private IProjectController _projectController;
        private IBacklogController _backlogController;
        private ISprintController _sprintController;
        private Form _currentChildForm;

        public MainFormController(IWindowsFormsFactory inFormFactory, IUserController inUserController, IProjectController inProjectController,
            IBacklogController inBacklogController, ISprintController inSprintController)
        {
            _formsFactory = inFormFactory;
            _userController = inUserController;
            _projectController = inProjectController;
            _backlogController = inBacklogController;
            _sprintController = inSprintController;
        }

        /// <summary>
        /// Opens Child Form inside Main Forms panel container.
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="childForm"></param>
        public void OpenChildForm(IMainFormView mainForm, Form childForm)
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
                mainForm.ChildFormsContainer.Controls.Add(childForm);
                mainForm.ChildFormsContainer.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }

        }

        public bool LoginUser(ILoginUserView loginUserView)
        {
            return _userController.LoginUser(loginUserView);
        }     

        public void OpenLoginForm(IMainFormView mainForm)
        {
            var newFrm = _formsFactory.CreateLoginUserView(this, mainForm);
            OpenChildForm(mainForm, (Form)newFrm);
        }

        public void OpenSignUpForm(IMainFormView mainView)
        {
            var newFrm = _formsFactory.CreateSignUpUserView(this, mainView);
            OpenChildForm(mainView, (Form)newFrm);
        }

        public bool SignUpUser(ISignUpUserView signUpUserView)
        {
            return _userController.SignUpUser(signUpUserView);
        }

        public void OpenHomePage(IMainFormView mainView)
        {
            var newFrm = _formsFactory.CreateHomeView(this, mainView, _projectController);

            OpenChildForm(mainView, (Form)newFrm);
        }

        public void AddProject()
        {
            List<User> members = _userController.GetAllSelectableUsers();
            var newFrm = _formsFactory.CreateAddNewProjectView(members, "Add new project", null);
            _projectController.AddNewProject(newFrm);
        }

        public void OpenProjectView(IMainFormView mainView, Project selected)
        {
            GlobalInfo.CurrentProject = selected;
            _projectController.CheckIfSprintEnded();
            _projectController.SetActiveSprint();
            var inProjectViewController = new ProjectViewController(_formsFactory, _backlogController, _sprintController);
            var newFrm = _formsFactory.CreateProjectView(this, mainView, inProjectViewController);

            OpenChildForm(mainView, (Form)newFrm);
        }

        public void DeleteProject(Project project)
        {
            _projectController.DeleteProject(project);
        }

        public void EditProject(IMainFormView mainView, Project project)
        {
            List<User> members = _userController.GetAllSelectableUsers();
            var newFrm = _formsFactory.CreateAddNewProjectView(members, "Edit project \"" + project.Name + "\"", project);
            _projectController.EditProject(project, newFrm);
        }

        public void ExitProject(Project project)
        {
            _projectController.ExitProject(project);
        }
    }
}
