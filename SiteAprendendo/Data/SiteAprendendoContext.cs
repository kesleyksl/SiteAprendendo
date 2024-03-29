﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteAprendendo.Models
{
    public class SiteAprendendoContext : DbContext
    {
        public SiteAprendendoContext (DbContextOptions<SiteAprendendoContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SallesRecords> SalesRecord { get; set; }
       
    }
}
