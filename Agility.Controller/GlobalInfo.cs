using System;
using System.Collections.Generic;
using System.Text;

using Agility.DomainModel;

namespace Agility.Controller
{
    public static class GlobalInfo
    {
        private static User _currentUser;
        private static Project _currentProject;
        private static Sprint _currentSprint;

        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public static Project CurrentProject
        {
            get { return _currentProject; }
            set { _currentProject = value; }
        }

        public static Sprint CurrentSprint
        {
            get { return _currentSprint; }
            set { _currentSprint = value; }
        }
    }
}
