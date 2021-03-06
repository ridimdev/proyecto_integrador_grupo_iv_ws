﻿using System;
using System.Collections.Generic;

namespace techstore_ws.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Cliente = new HashSet<Cliente>();
            Empleado = new HashSet<Empleado>();
        }

        public int IdDistrito { get; set; }
        public string NomDistrito { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
