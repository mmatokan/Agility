using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.DomainModel.Factories
{
    public class ProjectFactory
    {
        public static Project CreateProject(string inName, string inDescription, DateTime inStartDate, DateTime inEndDate, List<User> inMembers) 
        { 
            return new Project(inName, inDescription, inStartDate, inEndDate, inMembers);
        }
    }
}
