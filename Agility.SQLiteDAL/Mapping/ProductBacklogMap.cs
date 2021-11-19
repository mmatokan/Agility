using System;
using System.Collections.Generic;
using System.Text;

using Agility.DomainModel;
using FluentNHibernate.Mapping;

namespace Agility.SQLiteDAL.Mapping
{
    public class ProductBacklogMap : ClassMap<ProductBacklog>
    {
        public ProductBacklogMap()
        {
            Id(p => p.BacklogId).GeneratedBy.Native();

            HasMany(p => p.BacklogRequirements)
                .KeyColumn("BacklogId")
                .Cascade.AllDeleteOrphan();

            References(p => p.Project);

            Table("Backlog");

        }
    }
}
