using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib.Repositories
{
    public interface IRequirementRepository
    {
        bool AddRequirement(Requirement requirement);

        bool RemoveRequirement(Requirement requirement);

        bool UpdateRequirement(Requirement requirement);
    }
}
