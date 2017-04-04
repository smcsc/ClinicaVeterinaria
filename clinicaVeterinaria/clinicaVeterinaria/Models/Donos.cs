﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clinicaVeterinaria.Models
{
    public class Donos{

        public int DonosID { get; set; }

        public string Nome { get; set; }

        public string Morada { get; set; }

        public string CodPostal { get; set; }

        public string NIF { get; set; }

        public double Altura { get; set; }

        public int Idade { get; set; }
    }
}