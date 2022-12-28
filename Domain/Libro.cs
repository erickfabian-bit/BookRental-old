﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Libro
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autores { get; set; }
        public string Edicion { get; set; }
        public int Anio { get; set; }
        public int IdEditorial { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
        public int Estado { get; set; } = 1;
    }
}
