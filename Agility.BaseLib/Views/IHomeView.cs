using System;
using System.Collections.Generic;
using System.Text;

using Agility.DomainModel;

namespace Agility.BaseLib
{
    public interface IHomeView : IObserver
    {
        void ShowListOfProjects();
    }
}
