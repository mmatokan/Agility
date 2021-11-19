using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public interface IProjectServices
    {
        bool AddProject(Project project);

        bool RemoveProject(Project project);

        bool UpdateProject(Project project);

        ProductBacklog GetProjectBacklog(Project project);

        Sprint GetCurrentProjectSprint(Project project);

        List<Sprint> GetEndedSprints(Project project);
    }
}
