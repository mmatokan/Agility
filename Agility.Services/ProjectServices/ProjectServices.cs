using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public class ProjectServices : IProjectServices
    {
        private IProjectRepository _projectRepository;

        public ProjectServices(IProjectRepository inProjectRepository)
        {
            _projectRepository = inProjectRepository;
        }

        public bool AddProject(Project project)
        {
            if (string.IsNullOrEmpty(project.Name))
            {
                throw new EmptyProjectFieldException("name");
            }
            if (project.StartDate > project.EndDate)
            {
                throw new InvalidProjectDateException();
            }
            if (project.Members.Count == 0)
            {
                throw new InvalidMembersCountException();
            }

            return _projectRepository.AddProject(project);
        }

        public Sprint GetCurrentProjectSprint(Project project)
        {
            List<Sprint> sprints = _projectRepository.GetProjectSprints(project) as List<Sprint>;
            foreach (Sprint s in sprints)
            {
                if (s.EndDate > DateTime.Now && s.StartDate < DateTime.Now)
                {
                    return s;
                }
            }
            return null;
        }

        public List<Sprint> GetEndedSprints(Project project)
        {
            if(project == null)
            {
                throw new NullReferenceException();
            }

            return _projectRepository.GetEndedSprints(project) as List<Sprint>;
        }

        public ProductBacklog GetProjectBacklog(Project project)
        {
            if (project == null)
            {
                throw new NullReferenceException();
            }

            return _projectRepository.GetProjectBacklog(project);
        }

        public bool RemoveProject(Project project)
        {
            if (project == null)
            {
                throw new NullReferenceException();
            }

            return _projectRepository.RemoveProject(project);
        }

        public bool UpdateProject(Project project)
        {
            if (project == null)
            {
                throw new NullReferenceException();
            }

            return _projectRepository.UpdateProject(project);
        }
    }
}
