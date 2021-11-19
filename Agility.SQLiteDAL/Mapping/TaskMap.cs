using System;
using System.Collections.Generic;
using System.Text;

using Agility.DomainModel;
using FluentNHibernate.Mapping;

namespace Agility.SQLiteDAL.Mapping
{
    public class TaskMap: ClassMap<Task>
    {
        public TaskMap()
        {
            Id(t => t.TaskId).GeneratedBy.Native();
            Map(t => t.Description);
            Map(t => t.Status);

            References(t => t.MemberWorking)
                .Nullable()
                .Not.LazyLoad();
            References(t => t.Requirement)
                .Not.LazyLoad()
                .Cascade.All();
            References(t => t.Sprint)
                .Not.LazyLoad()
                .Nullable();

            Table("Task");

        }
    }
}
