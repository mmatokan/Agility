using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib
{
    public interface ILoginUserView
    {
        string Email { get;}
        string Password { get; }
    }
}
