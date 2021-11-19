using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public interface ITaskServices
    {
        bool AddTask(Task task);

        bool RemoveTask(Task task);

        bool UpdateTask(Task task);
    }
}
