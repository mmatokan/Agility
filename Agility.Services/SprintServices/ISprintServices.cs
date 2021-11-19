using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public interface ISprintServices
    {
        bool AddSprint(Sprint sprint);

        bool RemoveSprint(Sprint sprint);

        bool UpdateSprint(Sprint sprint);

        List<Task> GetSprintTasks(Sprint sprint);
    }
}
