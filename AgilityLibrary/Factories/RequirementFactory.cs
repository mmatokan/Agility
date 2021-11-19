using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.DomainModel.Factories
{
    public class RequirementFactory
    {
        public static Requirement CreateRequirement(RequirementType.TypeEnum type, string title, string description, RequirementPriority.PriorityEnum priority, IList<Task> requirementTasks)
        {
            return new Requirement(type, title, description, priority, requirementTasks);
        }
    }
}
