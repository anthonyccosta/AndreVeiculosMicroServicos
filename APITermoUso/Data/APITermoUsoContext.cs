using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace APITermoUso.Data
{
    public class APITermoUsoContext : DbContext
    {
        public APITermoUsoContext (DbContextOptions<APITermoUsoContext> options)
            : base(options)
        {
        }

        public DbSet<Models.TermoDeUso> TermoDeUso { get; set; } = default!;
    }
}
