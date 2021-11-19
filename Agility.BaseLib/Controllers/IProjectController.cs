using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface IProjectController : IObservable
    {
        void AddNewProject(IAddNewProjectView inForm);
        void SetActiveSprint();
        void DeleteProject(Project project);
        List<Project> GetAllUsersProjects();
        bool ExitProject(Project project);
        void EditProject(Project project, IAddNewProjectView inForm);
        void CheckIfSprintEnded();
    }
}
