using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agility.BaseLib;
using Agility.Controller;
using Agility.PresentationLayer;
using Agility.Services;
using Agility.SQLiteDAL;

namespace Agility.AppStarter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsFormsFactory _formsFactory = new WindowsFormsFactory();

            IUserServices _userServices = new UserServices(UserRepository.getInstance());
            IProjectServices _projectServices = new ProjectServices(ProjectRepository.getInstance());
            IBacklogServices _backlogServices = new BacklogServices(BacklogRepository.getInstance());
            ISprintServices _sprintServices = new SprintServices(SprintRepository.getInstance());
            IRequirementServices _requirementServices = new RequirementServices(RequirementRepository.getInstance());
            ITaskServices _taskServices = new TaskServices(TaskRepository.getInstance());

            IUserController _userController = new UserController(_userServices);
            IProjectController _projectController = new ProjectController(_userServices, _projectServices, _backlogServices, _sprintServices, _requirementServices, _taskServices);
            IBacklogController _backlogController = new BacklogController(_backlogServices, _requirementServices);
            ISprintController _sprintController = new SprintController(_sprintServices, _projectServices, _taskServices);

            MainFormController _mainController = new MainFormController(_formsFactory, _userController, _projectController, _backlogController, _sprintController);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(_mainController));
        }
    }
}
