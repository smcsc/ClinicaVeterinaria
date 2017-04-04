using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace clinicaVeterinaria.Models
{
    public class VetsDB : DbContext
    {
        //Representar a Base de Dados
        //descrevendo as tabelas que lá estão contidas

        //representar o 'construtor' desta clase
        //identifica onde se encontra a Base de Dados
        public VetsDB() : base("VetsDBConnection") { }

        //descrever as 'tabelas' que estao na BD
        public virtual DbSet<Donos> Donos { get; set; }

    }
}