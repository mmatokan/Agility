using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agility.BaseLib;
using Agility.DomainModel;

namespace Agility.PresentationLayer
{
    public class WindowsFormsFactory : IWindowsFormsFactory
    {
        public IAddNewProjectView CreateAddNewProjectView(List<User> members, string title, Project project)
        {
            var newFrm = new frmCreateProject(members, title, project);

            return newFrm;
        }

        public IAddNewRequirementView CreateAddNewRequirementView(List<string> types, List<string> priorities, string title, Requirement inRequirement)
        {
            var newFrm = new frmAddRequirement(types, priorities, title, inRequirement);

            return newFrm;
        }

        public IAddNewSprintView CreateAddNewSprintView(List<DomainModel.Task> tasks)
        {
            var newFrm = new frmCreateSprint(tasks);

            return newFrm;
        }

        public IEditRequirementView CreateEditRequirementView(List<DomainModel.Task> tasks)
        {
            throw new NotImplementedException();
        }

        public IHomeView CreateHomeView(IMainFormController inMainController, IMainFormView inMainForm, IProjectController inProjectController)
        {
            var newFrm = new FrmHomeView(inMainController, inMainForm, inProjectController);

            return newFrm;
        }

        public ILoginUserView CreateLoginUserView(IMainFormController inMainController, IMainFormView inMainForm)
        {
            var newFrm = new frmLogIn(inMainController, inMainForm);

            return newFrm;
        }

        public IMainFormView CreateMainFormView(IMainFormController inMainController)
        {
            var newFrm = new frmMain(inMainController);

            return newFrm;
        }

        public IShowProjectView CreateProjectView(IMainFormController inMainController, IMainFormView inMainForm, IProjectViewController inProjectViewController)
        {
            var newFrm = new frmProjectView(inMainController, inMainForm, inProjectViewController);

            return newFrm;
        }

        public IShowBacklogView CreateShowBacklogView(IProjectViewController inProjectViewController, IShowProjectView inProjectView, IBacklogController inBacklogController)
        {
            var newFrm = new frmBacklog(inProjectViewController, inProjectView, inBacklogController);

            return newFrm;
        }

        public IShowProjectDashboardView CreateShowProjectDashboardView(IProjectViewController inProjectViewController, IShowProjectView inProjectView, IDashboardController inDashboardController)
        {
            var newFrm = new frmProjectDashboard(inProjectViewController, inProjectView, inDashboardController);

            return newFrm;
        }

        public IShowSprintView CreateShowSprintView(IProjectViewController inProjectViewController, IShowProjectView inProjectView, ISprintController inSprintController)
        {
            var newFrm = new frmSprint(inProjectViewController, inProjectView, inSprintController);

            return newFrm;
        }

        public ISignUpUserView CreateSignUpUserView(IMainFormController inMainController, IMainFormView inMainForm)
        {
            var newFrm = new frmSignUp(inMainController, inMainForm);

            return newFrm;
        }
    }
}
