using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HerreraR___ORMclaseBaseDatos.Models;

    public class SQL_ServerContext : DbContext
    {
        public SQL_ServerContext (DbContextOptions<SQL_ServerContext> options)
            : base(options)
        {
        }

        public DbSet<HerreraR___ORMclaseBaseDatos.Models.Facultad> Facultad { get; set; } = default!;

public DbSet<HerreraR___ORMclaseBaseDatos.Models.Carrera> Carrera { get; set; } = default!;

public DbSet<HerreraR___ORMclaseBaseDatos.Models.Estudiante> Estudiante { get; set; } = default!;
    }
