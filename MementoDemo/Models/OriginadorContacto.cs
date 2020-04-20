using System;

namespace MementoDemo.Models
{
    public class OriginadorContacto
    {
        public string nombre { set; get; }
        public string direccion { set; get; }
        public string telefono { set; get; }

        public MementoContacto CrearMemento()
        {
            Console.WriteLine("Originador: Crear Memento");
            return new MementoContacto(this.nombre, this.direccion, this.telefono);
        }

        public void RestaurarMemento(MementoContacto memento)
        {
            Console.WriteLine("Originador: Restaurando Memento");
            this.nombre = memento.nombre;
            this.direccion = memento.direccion;
            this.telefono = memento.telefono;
        }
    }
}
