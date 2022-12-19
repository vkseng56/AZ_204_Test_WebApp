using AZ_204_Linux_Web_App.Repository.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_204_Linux_Web_App.Repository
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
        }

        public DbSet<Course> Course { get; set; }
    }
}
