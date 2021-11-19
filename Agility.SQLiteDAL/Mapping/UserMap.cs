using System;
using System.Collections.Generic;
using System.Text;

using Agility.DomainModel;
using FluentNHibernate.Mapping;

namespace Agility.SQLiteDAL.Mapping
{
    public class UserMap: ClassMap<User>
    {
        public UserMap()
        {
            Id(u => u.UserId).GeneratedBy.Native();
            Map(u => u.Name);
            Map(u => u.Surname);
            Map(u => u.Email).Unique();
            Map(u => u.Password).Not.Nullable();

            HasManyToMany(u => u.UserProjects)
                .Cascade.SaveUpdate()
                .Table("UserProjects");

            HasMany(u => u.UserTasks)
                .KeyColumn("UserId")
                .Cascade.AllDeleteOrphan(); 

            Table("User");

        }
    }
}
