using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Agility.BaseLib
{
    public interface IMainFormView
    {
        Panel ChildFormsContainer { get; }
    }
}
