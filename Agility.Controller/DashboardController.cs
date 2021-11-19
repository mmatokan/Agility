using Agility.BaseLib;
using Agility.DomainModel;
using Agility.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Agility.Controller
{
    public class DashboardController : IDashboardController
    {
        private IBacklogController _backlogController;

        public DashboardController(IBacklogController inBacklogController)
        {
            _backlogController = inBacklogController;
        }

        public int GetNumOfHigh()
        {
            try
            {
                int i = 0;
                foreach (Requirement r in _backlogController.GetRequirements())
                {
                    if (!r.RequirementDone && r.Priority == RequirementPriority.PriorityEnum.HIGH)
                    {
                        i++;
                    }
                }
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int GetNumOfLow()
        {
            try
            {
                int i = 0;
                foreach (Requirement r in _backlogController.GetRequirements())
                {
                    if (!r.RequirementDone && r.Priority == RequirementPriority.PriorityEnum.LOW)
                    {
                        i++;
                    }
                }
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int GetNumOfMedium()
        {
            try
            {
                int i = 0;
                foreach (Requirement r in _backlogController.GetRequirements())
                {
                    if (!r.RequirementDone && r.Priority == RequirementPriority.PriorityEnum.MEDIUM)
                    {
                        i++;
                    }
                }
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int GetPercentageOfProjectDone()
        {
            int Done = GetRequirementsDone();
            int Total = GetRequirementsTotal();
            if (Total == 0)
                return 0;
            else
                return Done / Total;
        }

        public int GetProjectDaysLeft()
        {
            if (GlobalInfo.CurrentProject.EndDate > DateTime.Now)
                return (GlobalInfo.CurrentProject.EndDate - DateTime.Now).Days;
            else
                return 0;
            
        }

        public int GetRequirementsDone()
        {
            try
            {
                int i = 0;
                foreach (Requirement r in _backlogController.GetRequirements())
                {
                    if (r.RequirementDone)
                    {
                        i++;
                    }
                }
                return i;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int GetRequirementsLeft()
        {
            try
            {
                int i = 0;
                foreach (Requirement r in _backlogController.GetRequirements())
                {
                    if (!r.RequirementDone)
                    {
                        i++;
                    }
                }
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int GetRequirementsTotal()
        {
            try
            {
                return _backlogController.GetRequirements().Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int GetSprintDaysLeft()
        {
            if(GlobalInfo.CurrentSprint == null)
            {
                return -1;
            }
            else
            {
                if (GlobalInfo.CurrentSprint.EndDate > DateTime.Now)
                    return (GlobalInfo.CurrentSprint.EndDate - DateTime.Now).Days;
                else
                    return 0;
            }
            
        }
    }
}
