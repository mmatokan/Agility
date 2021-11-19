using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public class TaskServices : ITaskServices
    {
        private ITaskRepository _taskRepository;

        public TaskServices(ITaskRepository inTaskRepository)
        {
            _taskRepository = inTaskRepository;
        }

        public bool AddTask(Task task)
        {
            if (string.IsNullOrEmpty(task.Description))
            {
                throw new EmptyTaskDescriptionException();
            }

            return _taskRepository.AddTask(task);
        }

        public bool RemoveTask(Task task)
        {
            return _taskRepository.RemoveTask(task);
        }

        public bool UpdateTask(Task task)
        {
            return _taskRepository.UpdateTask(task);
        }
    }
}
