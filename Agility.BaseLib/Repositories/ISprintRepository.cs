using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib.Repositories
{
    public interface ISprintRepository
    {
        bool AddSprint(Sprint sprint);

        bool RemoveSprint(Sprint sprint);

        bool UpdateSprint(Sprint sprint);

        IList<Task> GetSprintTasks(Sprint sprint);
    }
}
