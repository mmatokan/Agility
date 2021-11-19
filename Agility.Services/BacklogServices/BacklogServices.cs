using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public class BacklogServices : IBacklogServices
    {
        private IBacklogRepository _backlogRepository;

        public BacklogServices(IBacklogRepository inBacklogRepository)
        {
            _backlogRepository = inBacklogRepository;
        }

        public bool AddBacklog(ProductBacklog backlog)
        {
            if(backlog == null)
            {
                throw new NullReferenceException();
            }

            return _backlogRepository.AddBacklog(backlog);
        }

        public List<Requirement> GetBacklogRequirements(ProductBacklog backlog)
        {
            if (backlog == null)
            {
                throw new NullReferenceException();
            }

            return _backlogRepository.GetBacklogRequirements(backlog) as List<Requirement>;
        }

        public List<Task> GetBacklogTask(ProductBacklog backlog)
        {
            if (backlog == null)
            {
                throw new NullReferenceException();
            }

            return _backlogRepository.GetBacklogTask(backlog) as List<Task>;
        }

        public bool UpdateBacklog(ProductBacklog backlog)
        {
            if (backlog == null)
            {
                throw new NullReferenceException();
            }

            return _backlogRepository.UpdateBacklog(backlog);
        }
    }
}
