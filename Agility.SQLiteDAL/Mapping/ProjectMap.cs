using System;
using System.Collections.Generic;
using System.Text;

using Agility.DomainModel;
using FluentNHibernate.Mapping;

namespace Agility.SQLiteDAL.Mapping
{
    public class ProjectMap: ClassMap<Project>
    {
        public ProjectMap()
        {
            Id(p => p.ProjectId).GeneratedBy.Native();
            Map(p => p.Name).Unique();
            Map(p => p.Description);
            Map(p => p.StartDate);
            Map(p => p.EndDate);

            HasManyToMany(p => p.Members)
                .Not.LazyLoad()
                .Cascade.SaveUpdate()
                .Table("UserProjects");

            HasMany(p => p.Sprints)
                .Not.LazyLoad()
                .KeyColumn("ProjectId")
                .Cascade.SaveUpdate();

            References(p => p.Backlog)
                .Cascade.AllDeleteOrphan();


            Table("Project");

        }
    }
}
