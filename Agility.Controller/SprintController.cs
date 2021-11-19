using Agility.BaseLib;
using Agility.DomainModel;
using Agility.DomainModel.Factories;
using Agility.Services;
using Agility.SQLiteDAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Agility.Controller
{
    public class SprintController : ISprintController
    {
		private ISprintServices _sprintServices;
		private IProjectServices _projectServices;
		private ITaskServices _taskServices;

		public SprintController(ISprintServices inSprintServices, IProjectServices inProjectServices, ITaskServices inTaskServices)
		{
			_sprintServices = inSprintServices;
			_projectServices = inProjectServices;
			_taskServices = inTaskServices;
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
		public List<Task> GetSprintTask()
        {
			if(GlobalInfo.CurrentSprint != null)
            {
				try
				{
					List<Task> tasks = _sprintServices.GetSprintTasks(GlobalInfo.CurrentSprint);
					return tasks;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return null;
				}
			}
            else
            {
				return null;
            }
			

		}

		public bool AddNewSprint(IAddNewSprintView inForm)
		{
			if (inForm.ShowViewModal() == true)
			{
				try
				{
					string Title = inForm.SprintTitle;
					DateTime StartDate = inForm.SprintStartDate;
					DateTime EndDate = inForm.SprintEndDate;
					List<Task> SprintTasks = inForm.SprintTasks;

					Sprint newSprint = SprintFactory.CreateSprint(StartDate, EndDate, Title, SprintTasks);
					foreach(Task t in newSprint.SprintTasks)
                    {
						t.Sprint = newSprint;
                    }
					newSprint.Project = GlobalInfo.CurrentProject;
					
					_sprintServices.AddSprint(newSprint);

					GlobalInfo.CurrentSprint = newSprint;

					_projectServices.UpdateProject(GlobalInfo.CurrentProject);

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

        public void UpdateTask(Task inTask, TaskStatus.StatusEnum inStatus)
        {
			try
			{
				switch (inStatus)
				{
					case TaskStatus.StatusEnum.TO_DO:
						inTask.Status = inStatus;
						inTask.MemberWorking = null;
						break;
					default:
						inTask.Status = inStatus;
						inTask.MemberWorking = GlobalInfo.CurrentUser;
						break;
				}

				_taskServices.UpdateTask(inTask);

				NotifyObservers();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        public string GetFormatedStartDate()
        {
			if (GlobalInfo.CurrentSprint != null)
				return GlobalInfo.CurrentSprint.StartDate.Day.ToString() + "."
						+ GlobalInfo.CurrentSprint.StartDate.Month.ToString() + "."
							+ GlobalInfo.CurrentSprint.StartDate.Year.ToString();
			else
				return "";
		}

        public string GetFormatedEndDate()
        {
			if (GlobalInfo.CurrentSprint != null)
				return GlobalInfo.CurrentSprint.EndDate.Day.ToString() + "."
						+ GlobalInfo.CurrentSprint.EndDate.Month.ToString() + "."
							+ GlobalInfo.CurrentSprint.EndDate.Year.ToString();
			else
				return "";
		}
    }
}
