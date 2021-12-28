using Microsoft.EntityFrameworkCore;
using Populations_list.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations_list.EF
{
    public class cityContext : DbContext
    {
        public DbSet<city> city { get; set; }

        public cityContext(DbContextOptions options) : base(options)
        {

        }
    }
}
