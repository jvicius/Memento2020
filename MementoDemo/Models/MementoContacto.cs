using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDemo.Models
{
    public class MementoContacto
    {
        public string nombre { set; get; }
        public string direccion { set; get; }
        public string telefono { set; get; }

        public DateTime fechaGuardado { set; get; }

        public MementoContacto(string nombre, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fechaGuardado = DateTime.Now;
        }
    }
}
