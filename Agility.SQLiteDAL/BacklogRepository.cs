using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using NHibernate;

namespace Agility.SQLiteDAL
{
    public class BacklogRepository : IBacklogRepository
    {
        private static BacklogRepository _instance;

        public static BacklogRepository getInstance()
        {
            return _instance ?? (_instance = new BacklogRepository());
        }

        public bool AddBacklog(ProductBacklog backlog)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(backlog);
                    transaction.Commit();
                }
                return true;
            }
        }


        public bool UpdateBacklog(ProductBacklog backlog)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(backlog);
                    transaction.Commit();
                }
                return true;
            }
        }


        public IList<Requirement> GetBacklogRequirements(ProductBacklog backlog)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Requirement> reqs = session.QueryOver<Requirement>()
                    .Where(x => x.Backlog == backlog)
                    .List<Requirement>();
                return reqs;
            }

        }
        
        public IList<Task> GetBacklogTask(ProductBacklog backlog)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Requirement> reqs = session.QueryOver<Requirement>()
                    .Where(x => x.Backlog == backlog)
                    .List<Requirement>();

                IList<Task> tasks = session.QueryOver<Task>()
                    .WhereRestrictionOn(t => t.Requirement).IsIn(reqs as List<Requirement>)
                    .List<Task>();

                return tasks;
            }

        }

    }
}
