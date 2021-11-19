using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface IBacklogController : IObservable
    {
        List<Requirement> GetRequirements();
        bool AddNewRequirement(IAddNewRequirementView inForm);
        void EditRequirement(IAddNewRequirementView inForm, Requirement req);
        List<Task> GetAllBacklogTasks();
        void DeleteRequirement(Requirement requirement);
    }
}
