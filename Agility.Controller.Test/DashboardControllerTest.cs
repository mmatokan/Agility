using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Agility.DomainModel;
using Autofac.Extras.Moq;
using Agility.BaseLib;

namespace Agility.Controller.Tests
{ 
    [TestClass]
    public class DashboardControllerTest
    {

        #region TestData
        private List<Requirement> GetListOfRequirements(int num)
        {
            List<Requirement> Reqs = new List<Requirement>();
            for(int i=0; i<num; i++)
            {
                Requirement NewRequirement = new Requirement
                {
                    Title = "Title",
                    Priority = RequirementPriority.PriorityEnum.HIGH,
                    Type = RequirementType.TypeEnum.FEATURE,
                    RequirementTasks = GetListOfTasks(i+1)
                };

                if (i % 2 == 0)
                    NewRequirement.RequirementDone = true;

                Reqs.Add(NewRequirement);
            }
            
            return Reqs;

        }

        private Task GetTask()
        {
            return new Task { Description = "task description" };
        }

        private List<Task> GetListOfTasks(int num)
        {
            List<Task> result = new List<Task>();
            for (int i = 0; i < num; i++)
                result.Add(GetTask());
            return result;
        }

        private void SetActiveSprint()
        {
            Sprint NewSprint = new Sprint
            {
                Name = "Ime Sprinta",
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(30),
                SprintTasks = GetListOfTasks(5)
            };

            GlobalInfo.CurrentSprint = NewSprint;
        }
        #endregion

        [TestMethod]
        public void GetSprintDaysLeftTest()
        {
            using(var mock = AutoMock.GetLoose())
            {
                mock.Mock<IBacklogController>();

                var MockDashboardController = mock.Create<DashboardController>();

                SetActiveSprint();

                int DaysLeft = MockDashboardController.GetSprintDaysLeft();

                Assert.AreEqual(29, DaysLeft);
            }
        }

        [TestMethod]
        public void GetRequirementsTotalTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IBacklogController>()
                    .Setup(x => x.GetRequirements())
                    .Returns(GetListOfRequirements(10));

                var MockDashboardController = mock.Create<DashboardController>();

                int Total = MockDashboardController.GetRequirementsTotal();

                Assert.AreEqual(10, Total);
            }
        }

        [TestMethod]
        public void GetRequirementsLeftTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IBacklogController>()
                    .Setup(x => x.GetRequirements())
                    .Returns(GetListOfRequirements(10));

                var MockDashboardController = mock.Create<DashboardController>();

                int Left = MockDashboardController.GetRequirementsLeft();

                Assert.AreEqual(5, Left);
            }
        }

        [TestMethod]
        public void GetRequirementsDoneTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IBacklogController>()
                    .Setup(x => x.GetRequirements())
                    .Returns(GetListOfRequirements(10));

                var MockDashboardController = mock.Create<DashboardController>();

                int Done = MockDashboardController.GetRequirementsDone();

                Assert.AreEqual(5, Done);
            }
        }

        [TestMethod]
        public void GetPercentageOfProjectDone()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IBacklogController>()
                    .Setup(x => x.GetRequirements())
                    .Returns(GetListOfRequirements(0));

                var MockDashboardController = mock.Create<DashboardController>();

                int Percentage = MockDashboardController.GetPercentageOfProjectDone();

                Assert.AreEqual(0, Percentage);
            }
        }
    }
}
