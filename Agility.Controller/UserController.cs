using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Agility.BaseLib;
using Agility.DomainModel;
using Agility.DomainModel.Factories;
using Agility.Services;

namespace Agility.Controller
{
    public class UserController : IUserController
    {
		private IUserServices _userServices;

        public UserController(IUserServices inUserServices)
        {
			_userServices = inUserServices;
        }


        public bool LoginUser(ILoginUserView inForm)
		{
			try
			{
				string Email = inForm.Email;
				string Password = inForm.Password;

				GlobalInfo.CurrentUser = _userServices.LoginUser(Email, Password);

				return true;
			}
            catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}

        public bool SignUpUser(ISignUpUserView inForm)
        {
			try
			{
				string Name = inForm.SingUpName;
				string Surname = inForm.SignUpSurname;
				string Email = inForm.SignUpEmail;
				string Password = inForm.SignUpPassword;

				User newUser = UserFactory.CreateUser(Name, Surname, Email, Password);

				GlobalInfo.CurrentUser = _userServices.SignUpUser(newUser);

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}


		public List<User> GetAllSelectableUsers()
		{
			try
			{
				return _userServices.GetAllSelectableUsers(GlobalInfo.CurrentUser);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return new List<User>();
			}
		}

	}
}
