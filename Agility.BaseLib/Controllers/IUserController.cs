using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface IUserController
    {
        bool LoginUser(ILoginUserView inForm);

        bool SignUpUser(ISignUpUserView inForm);

        List<User> GetAllSelectableUsers();

    }
}
