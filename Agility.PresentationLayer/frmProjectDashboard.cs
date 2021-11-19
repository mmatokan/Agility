using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agility.BaseLib;
namespace Agility.PresentationLayer
{
    public partial class frmProjectDashboard : Form, IShowProjectDashboardView
    {

        private IProjectViewController _projectViewController = null;
        private IDashboardController _dashboardController = null;
        private IShowProjectView _projectView;

        public frmProjectDashboard(IProjectViewController inProjectViewController, IShowProjectView inProjectView, IDashboardController inDashboardController)
        {
            _projectView = inProjectView;
            _projectViewController = inProjectViewController;
            _dashboardController = inDashboardController;

            InitializeComponent();

            SetDashboardInfo();
        }

        private void SetDashboardInfo()
        {
            int pdl = _dashboardController.GetProjectDaysLeft();
            if (pdl == 1)
            {
                lblProjectDaysLeft.Text = "1 day left";
            }
            else
            {
                lblProjectDaysLeft.Text = pdl.ToString() + " days left";
            }
            int sdl = _dashboardController.GetSprintDaysLeft();
            if (sdl == -1)
            {
                lblSprintDaysLeft.Text = "No active Sprint";
            }
            else if (sdl == 1)
            {
                lblSprintDaysLeft.Text = "1 day left";
            }
            else
            {
                lblSprintDaysLeft.Text = sdl.ToString() + " days left";
            }
            lblNumOfReqsLeft.Text = _dashboardController.GetRequirementsLeft().ToString() + " requirements left";
            lblNumOfReqsDone.Text = _dashboardController.GetRequirementsDone().ToString() + " requirements done";

            //setting circural chart
            int PercentageDone = _dashboardController.GetPercentageOfProjectDone();
            circularProgressBar.Text = PercentageDone.ToString() + "%";
            circularProgressBar.Value = PercentageDone;

            chartBacklogPriorities.Series["RequirementsByPriority"].Points.AddXY("High", _dashboardController.GetNumOfHigh());
            chartBacklogPriorities.Series["RequirementsByPriority"].Points.AddXY("Medium", _dashboardController.GetNumOfMedium());
            chartBacklogPriorities.Series["RequirementsByPriority"].Points.AddXY("Low", _dashboardController.GetNumOfLow());
            chartBacklogPriorities.Series["RequirementsByPriority"].Points[0].Color = Color.Maroon;
            chartBacklogPriorities.Series["RequirementsByPriority"].Points[1].Color = Color.Goldenrod;
            chartBacklogPriorities.Series["RequirementsByPriority"].Points[2].Color = Color.ForestGreen;
        }


        private void frmProjectDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
