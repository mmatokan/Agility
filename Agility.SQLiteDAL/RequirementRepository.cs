using System;
using System.Collections.Generic;
using System.Text;
using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using NHibernate;

namespace Agility.SQLiteDAL
{
    public class RequirementRepository : IRequirementRepository
    {
        private static RequirementRepository _instance;

        public static RequirementRepository getInstance()
        {
            return _instance ?? (_instance = new RequirementRepository());
        }

        public bool AddRequirement(Requirement requirement)
        {          
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(requirement);
                    transaction.Commit();
                }
                return true;
            }
        }

        public bool RemoveRequirement(Requirement requirement)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(requirement);
                    transaction.Commit();
                }
                return true;
            }
        }

        public bool UpdateRequirement(Requirement requirement)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(requirement);
                    transaction.Commit();
                }
                return true;
            }
        }

    }
}
