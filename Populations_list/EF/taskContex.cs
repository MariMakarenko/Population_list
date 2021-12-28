using Microsoft.EntityFrameworkCore;
using Populations_list.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations_list.EF
{
    public class taskContext : DbContext
    {
        public DbSet<task> task { get; set; }
        public taskContext(DbContextOptions options) : base(options)
        {

        }
    }
}
