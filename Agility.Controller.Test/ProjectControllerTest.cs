using Agility.DomainModel;
using Agility.Services;
using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Agility.Controller.Test
{
    [TestClass]
    public class ProjectControllerTest
    {
        #region Test Data
        private User GetValidUser()
        {
            User NewUser = new User
            {
                Name = "Ime",
                Surname = "Prezime",
                Email = "adresa@email.hr",
                Password = "lozinka"
            };

            return NewUser;
        }

        private Project GetValidProject()
        {
            List<User> Users = new List<User>();
            Users.Add(GetValidUser());

            Project NewProject = new Project
            {
                Name = "Ime projekta",
                Description = "Opis projekta",
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(30),
                Members = Users
            };

            return NewProject;
        }
        #endregion

        [TestMethod]
        public void ExitProjectAsLastMemberTest_ProjectIsDeleted()
        {
            using (var mock = AutoMock.GetLoose())
            {
                Project TestProject = GetValidProject();
                GlobalInfo.CurrentUser = GetValidUser();

                mock.Mock<IProjectServices>()
                    .Setup(x => x.RemoveProject(TestProject))
                    .Returns(true);

                var MockProjectController = mock.Create<ProjectController>();

                bool Result = MockProjectController.ExitProject(TestProject);

                Assert.IsTrue(Result);
            }
        }


    }
}
