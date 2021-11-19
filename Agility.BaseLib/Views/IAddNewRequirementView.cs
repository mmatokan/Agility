using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface IAddNewRequirementView
    {
        bool ShowViewModal();

        string ReqTitle { get; }
        string ReqDescription { get; }
        string ReqType { get; }
        string ReqPriority { get; }
        List<string> ReqTasks { get; }
    }
}
