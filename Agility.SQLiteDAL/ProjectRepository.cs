using System;
using System.Collections.Generic;
using Agility.BaseLib.Repositories;
using Agility.DomainModel;

using NHibernate;

namespace Agility.SQLiteDAL
{
    public class ProjectRepository : IProjectRepository
    {
        private static ProjectRepository _instance;

        public static ProjectRepository getInstance()
        {
            return _instance ?? (_instance = new ProjectRepository());
        }

        public bool AddProject(Project project)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                try
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        var id = session.Save(project);
                        transaction.Commit();
                    }
                    return true;
                }
                catch
                {
                    throw new ProjectExistsException(project.Name);
                }
                
            }
        }

        public IList<Sprint> GetProjectSprints(Project project)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Sprint> sprints = session.QueryOver<Sprint>()
                    .Inner.JoinQueryOver<Project>(x => x.Project)
                    .Where(x => x.ProjectId == project.ProjectId)
                    .List<Sprint>();
                
                return sprints;
            }
        }

        public ProductBacklog GetProjectBacklog(Project project)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<ProductBacklog> backlogs = session.QueryOver<ProductBacklog>()
                    .Inner.JoinQueryOver<Project>(x => x.Project)
                    .Where(x => x.ProjectId == project.ProjectId)
                    .List<ProductBacklog>();
                return backlogs[0];
            }
        }

        public bool RemoveProject(Project project)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(project);
                    transaction.Commit();
                }
                return true;
            }
        }

        public bool UpdateProject(Project project)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(project);
                    transaction.Commit();
                }
                return true;
            }
        }

        public IList<Sprint> GetEndedSprints(Project project)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Sprint> sprints = session.QueryOver<Sprint>()
                    .Inner.JoinQueryOver(x => x.Project)
                    .Where(x => x.ProjectId == project.ProjectId)
                    .And(x => x.EndDate < DateTime.Now)
                    .List<Sprint>();
                return null;
            }
        }
    }
}
