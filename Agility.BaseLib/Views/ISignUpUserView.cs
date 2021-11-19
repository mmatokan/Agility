using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface ISignUpUserView
    {
        string SingUpName { get; }
        string SignUpSurname { get; }
        string SignUpEmail { get; }
        string SignUpPassword { get; }
    }
}
