using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.DomainModel.Factories
{
    public class UserFactory
    {
        public static User CreateUser(string inName, string inSurname, string inEmail, string inPassword)
        {
            return new User(inName, inSurname, inEmail, inPassword);
        }
    }
}
