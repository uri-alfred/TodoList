﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models.Encuestas
{
    public class Respuesta
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdPregunta { get; set; }
    }
}
