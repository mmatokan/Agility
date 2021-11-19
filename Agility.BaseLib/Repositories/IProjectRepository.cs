using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib.Repositories
{
    public interface IProjectRepository
    {
        bool AddProject(Project project);

        bool RemoveProject(Project project);

        bool UpdateProject(Project project);

        ProductBacklog GetProjectBacklog(Project project);

        IList<Sprint> GetProjectSprints(Project project);

        IList<Sprint> GetEndedSprints(Project project);

    }
}
