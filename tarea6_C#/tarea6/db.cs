using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

class covidContext : DbContext
{

    public DbSet<Persona> personas {get; set;}
    public DbSet<Provicnia> provicnias {get; set;}
    public DbSet<Vacuna> vacunas {get; set;}
    public DbSet<Proceso> procesos {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source=Covid1.db");
    }

}

public class Persona{
    public int id {get; set;}
    public string cedula {get; set;}
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public int telefono {get; set;}
}
public class Provicnia{

    public int id {get; set;}
    public string Nombre {get; set;}
}
public class Vacuna{
    public int id {get; set;}
    public string Nombre {get; set;}
}
public class Proceso{
    public int id {get; set;}
    public DateTime Fecha {get; set;}
    public Persona Persona {get; set;}
    public Provicnia Provicnia {get; set;}
    public Vacuna Vacuna {get; set;}
}

public class Persona_cedula
    {
        public string? Cedula { get; set; }
        public string? Nombres { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? LugarNacimiento { get; set; }
        public string? IdSexo { get; set; }
        public string? IdEstadoCivil { get; set; }
        public string? IDEstatus { get; set; }
        public string? EstatusCedulaAzul { get; set; }
        public string? CedulaAnterior { get; set; }
        public bool ok { get; set; }
        public string? foto { get; set; }
    }

