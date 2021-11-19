using System;
using System.Collections.Generic;
using System.Text;
using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using NHibernate;

namespace Agility.SQLiteDAL
{
    public class SprintRepository : ISprintRepository
    {
        private static SprintRepository _instance;

        public static SprintRepository getInstance()
        {
            return _instance ?? (_instance = new SprintRepository());
        }

        public bool AddSprint(Sprint sprint)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(sprint);
                    transaction.Commit();
                }
                return true;
            }
        }

        public IList<Task> GetSprintTasks(Sprint sprint)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Task> tasks = session.QueryOver<Task>()
                    .Where(x => x.Sprint == sprint)
                    .List<Task>();

                return tasks;
            }
        }

        public bool RemoveSprint(Sprint sprint)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(sprint);
                    transaction.Commit();
                }
                return true;
            }
        }

        public bool UpdateSprint(Sprint sprint)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(sprint);
                    transaction.Commit();
                }
                return true;
            }
        }
    }
}
