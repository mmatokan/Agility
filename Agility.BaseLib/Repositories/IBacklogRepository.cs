using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib.Repositories
{
    public interface IBacklogRepository
    {
        bool AddBacklog(ProductBacklog backlog);

        bool UpdateBacklog(ProductBacklog backlog);

        IList<Requirement> GetBacklogRequirements(ProductBacklog backlog);

        IList<Task> GetBacklogTask(ProductBacklog backlog);


    }
}
