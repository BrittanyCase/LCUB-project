using Construction_Tool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Jet;
using System.Data.Entity;
using System.Data.Common;

namespace Construction_Tool.Contexts
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(string connection) : base(connection)
        {
        }
        public DbSet<ProjectViewModel> Projects { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ProjectContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
