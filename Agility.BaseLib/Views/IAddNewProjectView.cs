using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface IAddNewProjectView
    {
        bool ShowViewModal();

        string ProjectName { get; }
        string ProjectDescription { get; }
        DateTime ProjectStartDate { get; }
        DateTime ProjectEndDate { get; }
        List<User> ProjectMembers { get; }
    }
}
