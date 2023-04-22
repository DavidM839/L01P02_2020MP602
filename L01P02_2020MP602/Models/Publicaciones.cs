﻿using System.ComponentModel.DataAnnotations;

namespace L01P02_2020MP602.Models
{
    public class Publicaciones
    {//titulo,descripcion,usuarioId
        [Key]
        public int publicacionId { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int usuarioId { get; set; }
    }
}

