using MementoDemo.Models;
using System;

namespace MementoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            OriginadorContacto contacto = new OriginadorContacto();
            CuidadorMemento cuidadormemento = new CuidadorMemento(contacto);

            contacto.nombre = "Jose Velarde";
            contacto.direccion = "";
            contacto.telefono = "4491091868";
            cuidadormemento.Respaldar();

            contacto.nombre = "Jose Velarde Medina";
            contacto.direccion = "Las villas 123";
            contacto.telefono = "4491091867";
            cuidadormemento.Respaldar();

            contacto.nombre = "Jose Velarde";
            contacto.direccion = "Las villas 12356";
            contacto.telefono = "4491091867";

            cuidadormemento.HistorialMementos();

            Console.WriteLine("");
            Console.WriteLine($"{contacto.nombre} {contacto.direccion} {contacto.telefono}");

            cuidadormemento.Deshacer();

            Console.WriteLine($"{contacto.nombre} {contacto.direccion} {contacto.telefono}");






        }
    }
}
