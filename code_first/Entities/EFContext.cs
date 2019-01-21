using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace code_first.Entities
{
    public class EFContext : DbContext
    {
        public EFContext()
           : base("ConnectionStep")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
