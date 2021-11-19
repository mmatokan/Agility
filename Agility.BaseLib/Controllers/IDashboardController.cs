using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface IDashboardController
    {
        int GetProjectDaysLeft();
        int GetSprintDaysLeft();
        int GetRequirementsLeft();
        int GetRequirementsDone();
        int GetRequirementsTotal();
        int GetPercentageOfProjectDone();
        int GetNumOfHigh();
        int GetNumOfMedium();
        int GetNumOfLow();
    }
}
