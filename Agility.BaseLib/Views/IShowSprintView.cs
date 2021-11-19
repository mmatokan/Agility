using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface IShowSprintView : IObserver
    {
        void ShowListOfTasks();
    }
}
