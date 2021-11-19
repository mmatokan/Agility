using System;
using System.Collections.Generic;
using System.Text;
using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using NHibernate;

namespace Agility.SQLiteDAL
{
    public class TaskRepository : ITaskRepository
    {
        private static TaskRepository _instance;

        public static TaskRepository getInstance()
        {
            return _instance ?? (_instance = new TaskRepository());
        }

        public bool AddTask(Task task)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(task);
                    transaction.Commit();
                }
                return true;
            }
        }

        public bool RemoveTask(Task task)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(task);
                    transaction.Commit();
                }
                return true;
            }
        }

        public bool UpdateTask(Task task)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(task);
                    transaction.Commit();
                }
                return true;
            }
        }
    }
}
