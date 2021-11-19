using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public class RequirementServices : IRequirementServices
    {
        private IRequirementRepository _requirementRepository;

        public RequirementServices(IRequirementRepository inRequirementRepository)
        {
            _requirementRepository = inRequirementRepository;
        }

        public bool AddRequirement(Requirement requirement)
        {
            if (string.IsNullOrEmpty(requirement.Title))
            {
                throw new EmptyRequirementFieldException("title");
            }
            if (requirement.RequirementTasks.Count == 0)
            {
                throw new TasksCountException();
            }

            return _requirementRepository.AddRequirement(requirement);
        }

        public bool RemoveRequirement(Requirement requirement)
        {
            if(requirement == null)
            {
                throw new NullReferenceException();
            }

            return _requirementRepository.RemoveRequirement(requirement);
        }

        public bool UpdateRequirement(Requirement requirement)
        {
            if (requirement == null)
            {
                throw new NullReferenceException();
            }

            return _requirementRepository.UpdateRequirement(requirement);
        }
    }
}
