using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Company.DomainModels;

namespace Company.DataLayer
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("ReportingAssistantDb")
        {

        }

        public DbSet<DomainModels.Task> Tasks { get; set; }
        public DbSet<TaskDone> TasksDone { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet<FinalComment> FinalComments { get; set; }

        
    }
}
