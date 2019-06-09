using Microsoft.EntityFrameworkCore;
using System;
using Model;
using System.Collections.Generic;
using System.Text;

namespace Persisten
{
    public class FacturadbContext : DbContext
    {
        public DbSet<Factura> Facturas { get; set; }

        public FacturadbContext(DbContextOptions<FacturadbContext> options)
            : base(options) { }
    }

    
    
}
