using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.EntityFrameworkCore;



namespace Обучение
{
    public class DbAppContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = ConfigurationManager.ConnectionStrings["EmpDb"].ConnectionString;
            optionsBuilder.UseNpgsql(cs);
        }
    }
}
