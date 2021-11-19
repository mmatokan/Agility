using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.DomainModel.Factories
{
    public class SprintFactory
    {
        public static Sprint CreateSprint(DateTime startDate, DateTime endDate, string name, List<Task> sprintTasks)
        {
            return new Sprint(startDate, endDate, name, sprintTasks);
        }
    }
}
