using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

class animeContext : DbContext
{

    public DbSet<Personaje> personajes {get; set;}
    public DbSet<Serie> series {get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source=anime.db");
    }

}

public class Personaje
{
    public int id {get; set; }
    public string? nombre{get; set;}
    public string? apellido{get; set;}
    public string? foto{get; set;}
    public string? pronunciacion{get; set;}
    public DateTime fecha_nacimiento{get; set;}
    public string? frase{get; set;}
    public string? poder {get; set;}
    public string? descripcion{get; set;}
    public string? altura{get; set;}
    public string? sexo{get; set;}
    public string? estado{get; set;}
    public string? direccin{get; set;}
    public float latitud{get; set;}
    public float longitud{get; set;}
    public int serieid{get; set;}
    public Serie serie {get; set;}
}


public class Serie
{

    public int id {get; set;}
    public string? nombre {get; set;}

    public List<Personaje> personaje {get;} = new();
}