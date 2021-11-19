using System;
using System.Collections.Generic;
using Agility.DomainModel;

namespace Agility.BaseLib
{
    public interface IShowBacklogView : IObserver
    {
        void ShowListOfRequirements();
    }
}
