using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib.Repositories
{
    public interface ITaskRepository
    {
        bool AddTask(Task task);

        bool RemoveTask(Task task);

        bool UpdateTask(Task task);
    }
}
