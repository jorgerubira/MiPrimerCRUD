﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInfraestructura.Entities
{
    [Table("Centros")]
    public class Centro
    {
        [Key]
        public long Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }

    }
}
