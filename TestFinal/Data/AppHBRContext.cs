using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestFinal.Models;

namespace TestFinal.Data
{
    public class AppHBRContext : DbContext
    {
        public AppHBRContext(DbContextOptions<AppHBRContext> options) : base(options) { }
        public DbSet<enProducto> Productos { get; set; }
        public DbSet<enCategoria> Categoria { get; set; }
    }
    
}
