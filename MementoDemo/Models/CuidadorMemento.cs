using System;
using System.Collections.Generic;
using System.Linq;

namespace MementoDemo.Models
{
    public class CuidadorMemento
    {
        private List<MementoContacto> _mementos;
        private OriginadorContacto _originador = null;

        public CuidadorMemento(OriginadorContacto originadorContacto)
        {
            _originador = originadorContacto;
            _mementos = new List<MementoContacto>();
        }

        public void Respaldar()
        {
            Console.WriteLine("Cuidador: respaldo Memento");
            this._mementos.Add(_originador.CrearMemento());
        }

        public void Deshacer()
        {
            if (_mementos.Count==0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            Console.WriteLine("Cuidador: restaurando memento");
            this._originador.RestaurarMemento(memento);
        }

        public void HistorialMementos()
        {
            Console.WriteLine("Cuidador: Historial Mementos");

            foreach(var item in this._mementos)
            {
                Console.WriteLine($"{item.nombre} {item.direccion} {item.telefono}");
            }
        }
    }
}
