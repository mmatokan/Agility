using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface ISprintController : IObservable
    {
        List<Task> GetSprintTask();
        bool AddNewSprint(IAddNewSprintView inForm);
        void UpdateTask(Task inTask, TaskStatus.StatusEnum inStatus);

        string GetFormatedStartDate();
        string GetFormatedEndDate();
    }
}
