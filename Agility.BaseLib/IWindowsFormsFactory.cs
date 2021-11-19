using System;
using System.Collections.Generic;
using System.Text;
using Agility.DomainModel;

namespace Agility.BaseLib
{
    public interface IWindowsFormsFactory
    {
        IMainFormView CreateMainFormView(IMainFormController inMainController);

        IAddNewProjectView CreateAddNewProjectView(List<User> members, string title, Project project);

        IAddNewRequirementView CreateAddNewRequirementView(List<string> types, List<string> priorities, string title, Requirement inRequirement);

        IAddNewSprintView CreateAddNewSprintView(List<Task> tasks);

        IEditRequirementView CreateEditRequirementView(List<Task> tasks);
        
        IHomeView CreateHomeView(IMainFormController inMainController, IMainFormView inMainForm, IProjectController inProjectController);

        ILoginUserView CreateLoginUserView(IMainFormController inMainController, IMainFormView inMainForm);

        IShowBacklogView CreateShowBacklogView(IProjectViewController inProjectViewController, IShowProjectView inProjectView, IBacklogController inBacklogController);

        IShowProjectDashboardView CreateShowProjectDashboardView(IProjectViewController inProjectViewController, IShowProjectView inProjectView, IDashboardController inDashboardController);

        IShowSprintView CreateShowSprintView(IProjectViewController inProjectViewController, IShowProjectView inProjectView, ISprintController inSprintController);

        ISignUpUserView CreateSignUpUserView(IMainFormController inMainController, IMainFormView inMainForm);

        IShowProjectView CreateProjectView(IMainFormController inMainController, IMainFormView inMainForm, IProjectViewController inProjectViewController);

    }
}
