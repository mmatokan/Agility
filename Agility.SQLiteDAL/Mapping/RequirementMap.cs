using System;
using System.Collections.Generic;
using System.Text;

using Agility.DomainModel;
using FluentNHibernate.Mapping;

namespace Agility.SQLiteDAL.Mapping
{
    class RequirementMap: ClassMap<Requirement>
    {
        public RequirementMap()
        {
            Id(r => r.RequirementId).GeneratedBy.Native();
            Map(r => r.Title);
            Map(r => r.Description);
            Map(r => r.Priority);
            Map(r => r.Type);
            Map(r => r.RequirementDone);

            References(r => r.Backlog);
            HasMany(r => r.RequirementTasks)
                .KeyColumn("RequirementId").Not.LazyLoad()
                .Cascade.AllDeleteOrphan();

            Table("Requirement");

        }
    }
}
