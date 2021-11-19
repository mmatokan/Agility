using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Agility.BaseLib
{
    public interface IMainFormController
    {
        void OpenLoginForm(IMainFormView mainForm);
        bool LoginUser(ILoginUserView loginUserView);
        bool SignUpUser(ISignUpUserView signUpUserView);
        void OpenSignUpForm(IMainFormView mainView);
        void OpenHomePage(IMainFormView mainView);
        void AddProject();
        void OpenProjectView(IMainFormView mainView, Project selected);
        void DeleteProject(Project project);
        void EditProject(IMainFormView mainView, Project project);
        void ExitProject(Project project);
    }
}
