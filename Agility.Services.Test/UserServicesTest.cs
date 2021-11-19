using Agility.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using Autofac.Extras.Moq;
using Agility.BaseLib.Repositories;

namespace Agility.Services.Test
{
    [TestClass]
    public class UserServicesTest
    {
        private User _testUser;

        [TestInitialize]
        public void SetValidUser()
        {
            _testUser = new User
            {
                Name = "Ime",
                Surname = "Prezime",
                Email = "adresa@email.hr",
                Password = "lozinka"
            };
        }

        private User GetUser()
        {
            User NewUser = new User
            {
                UserId = 0,
                Name = "Ime",
                Surname = "Prezime",
                Email = "adresa@email.hr",
                Password = "lozinka"
            };

            return NewUser;
        }

        [TestMethod]
        public void ValidSignUpUser_ReturnsUser()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IUserRepository>()
                    .Setup(x => x.SignUpUser(new User()))
                    .Returns(GetUser());

                var MockUserService = mock.Create<UserServices>();

                User result = MockUserService.SignUpUser(_testUser);

                Assert.IsTrue(result.Equals(GetUser()));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEmailAddressException))]
        public void InvalidSignUpEmailAddress_ThrowsException()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IUserRepository>()
                    .Setup(x => x.SignUpUser(new User()))
                    .Returns(GetUser());

                var MockUserService = mock.Create<UserServices>();
                _testUser.Email = "pero.com";
                MockUserService.SignUpUser(_testUser);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(EmptySignUpFieldException))]
        public void EmptyPasswordFiledOnSignUp_ThrowsException()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IUserRepository>()
                    .Setup(x => x.SignUpUser(new User()))
                    .Returns(GetUser());

                var MockUserService = mock.Create<UserServices>();
                _testUser.Password = "";
                MockUserService.SignUpUser(_testUser);
            }
        }

        [TestMethod]
        public void ValidUserLogin_ReturnsUser()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IUserRepository>()
                    .Setup(x => x.LoginUser(_testUser.Email, _testUser.Password))
                    .Returns(GetUser());

                var MockUserService = mock.Create<UserServices>();

                User result = MockUserService.LoginUser(_testUser.Email, _testUser.Password);

                Assert.IsTrue(result.Equals(GetUser()));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyLoginFieldException))]
        public void EmptyPasswordFiledOnLogin_ThrowsException()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IUserRepository>()
                    .Setup(x => x.LoginUser(_testUser.Email, _testUser.Password))
                    .Returns(GetUser());

                var MockUserService = mock.Create<UserServices>();

                MockUserService.LoginUser(_testUser.Email, "");
            }
        }
    }
}
