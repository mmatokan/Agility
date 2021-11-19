using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface IProjectViewController
    {
        void OpenProjectDashboard(IShowProjectView projectView);
        void OpenProjectBacklog(IShowProjectView projectView);
        void OpenProjectSprint(IShowProjectView projectView);
        bool AddRequirement();
        bool AddSprint();
        void EditRequirement(Requirement requirement);
        void DeleteRequirement(Requirement requirement);
        User GetCurrentUser();
    }
}
