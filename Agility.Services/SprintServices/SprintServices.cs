using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public class SprintServices : ISprintServices
    {
        private ISprintRepository _sprintRepository;

        public SprintServices(ISprintRepository inSprintRepository)
        {
            _sprintRepository = inSprintRepository;
        }

        public bool AddSprint(Sprint sprint)
        {
            if (string.IsNullOrEmpty(sprint.Name))
            {
                throw new EmptySprintFieldException("name");
            }
            if (sprint.SprintTasks == null)
            {
                throw new SprintTasksCountException();
            }
            if (sprint.StartDate > sprint.EndDate)
            {
                throw new InvalidSprintDateException();
            }

            return _sprintRepository.AddSprint(sprint);
        }

        public List<Task> GetSprintTasks(Sprint sprint)
        {
            if(sprint == null)
            {
                throw new NullReferenceException();
            }

            return _sprintRepository.GetSprintTasks(sprint) as List<Task>;
        }

        public bool RemoveSprint(Sprint sprint)
        {
            if (sprint == null)
            {
                throw new NullReferenceException();
            }

            return _sprintRepository.RemoveSprint(sprint);
        }

        public bool UpdateSprint(Sprint sprint)
        {
            if (sprint == null)
            {
                throw new NullReferenceException();
            }

            return _sprintRepository.UpdateSprint(sprint);
        }
    }
}
