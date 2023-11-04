using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{
    public class MuhasebeContext:DbContext
    {
        public DbSet<Product1> Products { get; set; }
    }
}
