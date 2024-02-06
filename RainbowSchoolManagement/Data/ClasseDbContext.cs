using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchoolManagement.Models;

namespace RainbowSchoolManagement.Data
{
    public class ClasseDbContext : DbContext
    {
        public ClasseDbContext (DbContextOptions<ClasseDbContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchoolManagement.Models.Classe> Classe { get; set; } = default!;
    }
}
