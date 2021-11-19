using System;
using System.Collections.Generic;
using System.Text;

using Agility.DomainModel;
using FluentNHibernate.Mapping;

namespace Agility.SQLiteDAL.Mapping
{
    class SprintMap : ClassMap<Sprint>
    {
        public SprintMap()
        {
            Id(s => s.SprintId).GeneratedBy.Native();
            Map(s => s.Name);
            Map(s => s.StartDate);
            Map(s => s.EndDate);

            HasMany(p => p.SprintTasks)
                .KeyColumn("SprintId")
                .Cascade.AllDeleteOrphan();

            References(p => p.Project);

            Table("Sprint");

        }
    }
}
