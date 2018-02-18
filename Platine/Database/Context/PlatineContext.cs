using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platine.Database.BusinessObject;

namespace Platine.Database.Context
{
    public class PlatineContext : DbContext
    {
        // TODO really ugly way to do this.
        public PlatineContext() : base("Platine")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectDetail> ProjectDetail { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillName> SkillNames { get; set; }


    }
}