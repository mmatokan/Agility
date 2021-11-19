using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public interface IBacklogServices
    {
        bool AddBacklog(ProductBacklog backlog);

        bool UpdateBacklog(ProductBacklog backlog);

        List<Requirement> GetBacklogRequirements(ProductBacklog backlog);

        List<Task> GetBacklogTask(ProductBacklog backlog);
    }
}
