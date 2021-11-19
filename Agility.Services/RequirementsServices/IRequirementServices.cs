using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public interface IRequirementServices
    {
        bool AddRequirement(Requirement requirement);

        bool RemoveRequirement(Requirement requirement);

        bool UpdateRequirement(Requirement requirement);
    }
}
