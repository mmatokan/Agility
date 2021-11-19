using Agility.BaseLib;
using Agility.DomainModel;
using Agility.DomainModel.Factories;
using Agility.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Agility.Controller
{
    public class BacklogController : IBacklogController
    {
		private IBacklogServices _backlogServices;
		private IRequirementServices _requirementServices;

		public BacklogController(IBacklogServices inBacklogServices, IRequirementServices inRequirementService)
		{
			_backlogServices = inBacklogServices;
			_requirementServices = inRequirementService;
		}
		#region Subject
		List<IObserver> _listObservers = new List<IObserver>();

		public void Attach(IObserver obs)
		{
			_listObservers.Add(obs);
		}
		public void Delete(IObserver obs)
		{
			_listObservers.Remove(obs);
		}
		public void NotifyObservers()
		{
			foreach (IObserver obs in _listObservers)
				obs.Update();
		}
		#endregion

		public List<Requirement> GetRequirements()
        {
			try
			{
				List<Requirement> reqs = _backlogServices.GetBacklogRequirements(GlobalInfo.CurrentProject.Backlog);
				return reqs;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
                return null;
			}
		}

		public bool AddNewRequirement(IAddNewRequirementView inForm)
		{
			if (inForm.ShowViewModal() == true)
			{
				try
				{
					string Title = inForm.ReqTitle;
					string Description = inForm.ReqDescription;
					string typeDesription = inForm.ReqType;
					string priorityDescription = inForm.ReqPriority;
					List<string> tasksDescriptions = inForm.ReqTasks;

					RequirementType.TypeEnum Type = RequirementType.DesToType[typeDesription];
					RequirementPriority.PriorityEnum Priority = RequirementPriority.DesToPrority[priorityDescription];
					List<Task> Tasks = new List<Task>();

					foreach(string td in tasksDescriptions)
                    {
						Tasks.Add(new Task(td));
                    }

					Requirement newRequirement = RequirementFactory.CreateRequirement(Type, Title, Description, Priority, Tasks);
					newRequirement.Backlog = GlobalInfo.CurrentProject.Backlog;
					foreach(Task t in newRequirement.RequirementTasks)
                    {
						t.Requirement = newRequirement;
                    }
					_requirementServices.AddRequirement(newRequirement);
					NotifyObservers();
					return true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);

					return false;
				}
			}
			return false;
		}

        public void EditRequirement(IAddNewRequirementView inForm, Requirement req)
        {
			if (inForm.ShowViewModal() == true)
			{
				try
				{
					string Title = inForm.ReqTitle;
					string Description = inForm.ReqDescription;
					string typeDesription = inForm.ReqType;
					string priorityDescription = inForm.ReqPriority;
					List<string> tasksDescriptions = inForm.ReqTasks;

					RequirementType.TypeEnum Type = RequirementType.DesToType[typeDesription];
					RequirementPriority.PriorityEnum Priority = RequirementPriority.DesToPrority[priorityDescription];
					List<Task> Tasks = new List<Task>();

					foreach (string td in tasksDescriptions)
					{
						Tasks.Add(new Task(td));
					}

					Requirement newRequirement = RequirementFactory.CreateRequirement(Type, Title, Description, Priority, Tasks);
					newRequirement.Backlog = GlobalInfo.CurrentProject.Backlog;
					foreach (Task t in newRequirement.RequirementTasks)
					{
						t.Requirement = newRequirement;
					}
					newRequirement.RequirementId = req.RequirementId;
					_requirementServices.UpdateRequirement(newRequirement);
					NotifyObservers();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

        public List<Task> GetAllBacklogTasks()
        {
			try
			{
				List<Task> tasks = _backlogServices.GetBacklogTask(GlobalInfo.CurrentProject.Backlog);
				return tasks;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

        public void DeleteRequirement(Requirement requirement)
        {
			try
			{
				_requirementServices.RemoveRequirement(requirement);
				NotifyObservers();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
    }
}
