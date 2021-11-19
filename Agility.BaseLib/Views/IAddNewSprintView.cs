using System;
using System.Collections.Generic;
using System.Text;
using Agility.DomainModel;

namespace Agility.BaseLib
{
    public interface IAddNewSprintView
    {
        bool ShowViewModal();

        string SprintTitle { get; }
        DateTime SprintStartDate { get; }
        DateTime SprintEndDate { get; }
        List<Task> SprintTasks { get; }
    }
}
