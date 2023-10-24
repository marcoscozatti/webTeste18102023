using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webTeste18102023.Models;

namespace webTeste18102023.Data
{
    public class PacienteContext : DbContext
    {
        public PacienteContext (DbContextOptions<PacienteContext> options)
            : base(options)
        {
        }

        public DbSet<webTeste18102023.Models.Paciente> Paciente { get; set; }
    }
}
