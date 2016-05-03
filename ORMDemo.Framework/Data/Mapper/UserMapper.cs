using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMDemo.Data.Model;

namespace ORMDemo.Data.Mapper
{
    public class UserMapper : EntityTypeConfiguration<UserModel>
    {
        public UserMapper()
        {
            ToTable("t_user");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).IsRequired().HasMaxLength(20);
        }
    }
}
