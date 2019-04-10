using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarvestApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace HarvestApp2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Value> Values { get; set; }
        
       
    }
}
