using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Agility.BaseLib;
using Agility.DomainModel;
using Agility.DomainModel.Factories;
using Agility.Services;
using Agility.SQLiteDAL;

namespace Agility.Controller
{
    public class ProjectController : IProjectController 
    {
		private IUserServices _userServices;
		private IProjectServices _projectServices;
		private IBacklogServices _backlogServices;
		private ISprintServices _sprintServices;
		private IRequirementServices _requirementServices;
		private ITaskServices _taskServices;

        public ProjectController(IUserServices inUserService, IProjectServices projectServices, IBacklogServices backlogServices, 
			ISprintServices sprintServices, IRequirementServices requirementServices, ITaskServices taskServices)
        {
			_userServices = inUserService;
            _projectServices = projectServices;
            _backlogServices = backlogServices;
            _sprintServices = sprintServices;
            _requirementServices = requirementServices;
            _taskServices = taskServices;
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

        public void AddNewProject(IAddNewProjectView inForm)
		{
			if (inForm.ShowViewModal() == true)
			{
				try
				{
					string Name = inForm.ProjectName;
					string Descreption = inForm.ProjectDescription;
					DateTime StartDate = inForm.ProjectStartDate;
					DateTime EndDate = inForm.ProjectEndDate;
					List<User> Members = inForm.ProjectMembers;
					Members.Add(GlobalInfo.CurrentUser);

					ProductBacklog backlog = new ProductBacklog();
					_backlogServices.AddBacklog(backlog);

					Project newProject = ProjectFactory.CreateProject(Name, Descreption, StartDate, EndDate, Members);

					newProject.Backlog = backlog;

					_projectServices.AddProject(newProject);

					NotifyObservers();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

        public void SetActiveSprint()
        {
			try
            {
				GlobalInfo.CurrentSprint = _projectServices.GetCurrentProjectSprint(GlobalInfo.CurrentProject);
            }
            catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
        }

        public void DeleteProject(Project project)
        {
			try
			{
				_projectServices.RemoveProject(project);
				NotifyObservers();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public bool ExitProject(Project project)
		{
			try
			{
				bool Result;
				project.Members.Remove(GlobalInfo.CurrentUser);
				if(project.Members.Count == 0)                
					Result = _projectServices.RemoveProject(project);
                else
					Result = _projectServices.UpdateProject(project);
				NotifyObservers();
				return Result;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}

		public List<Project> GetAllUsersProjects()
		{
			try
			{
				List<Project> userProjects = _userServices.GetUserProjects(GlobalInfo.CurrentUser);
				return userProjects;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public void EditProject(Project project, IAddNewProjectView inForm)
        {
			if (inForm.ShowViewModal() == true)
			{
				try
				{
					string Name = inForm.ProjectName;
					string Descreption = inForm.ProjectDescription;
					DateTime StartDate = inForm.ProjectStartDate;
					DateTime EndDate = inForm.ProjectEndDate;
					List<User> Members = inForm.ProjectMembers;
					Members.Add(GlobalInfo.CurrentUser);

					Project newProject = ProjectFactory.CreateProject(Name, Descreption, StartDate, EndDate, Members);
					newProject.ProjectId = project.ProjectId;
					newProject.Backlog = project.Backlog;

					_projectServices.UpdateProject(newProject);

					NotifyObservers();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

        public void CheckIfSprintEnded()
        {
			try
			{
				List<Sprint> endedSprints = _projectServices.GetEndedSprints(GlobalInfo.CurrentProject);
				if (endedSprints != null)
                {
					foreach(Sprint s in endedSprints)
                    {
						foreach(Task t in s.SprintTasks)
                        {
							if(t.Status == TaskStatus.StatusEnum.DONE)
                            {
								_taskServices.RemoveTask(t);
                            }
                            else
                            {
								t.Status = TaskStatus.StatusEnum.TO_DO;
								t.MemberWorking = null;
								_taskServices.UpdateTask(t);
                            }
                        }
						_sprintServices.RemoveSprint(s);
                    }

					// check if all tasks in requirement are done
					IBacklogController _backlogController = new BacklogController(_backlogServices, _requirementServices);
					foreach(Requirement r in _backlogController.GetRequirements())
                    {
						if(r.RequirementTasks == null)
                        {
							r.RequirementDone = true;
							_requirementServices.UpdateRequirement(r);
                        }
                    }
					
                }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
    }
}
