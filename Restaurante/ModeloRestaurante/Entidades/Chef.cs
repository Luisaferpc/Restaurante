using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloRestaurante.Entidades
{
    public class Chef
    {
        //Data Notaciones, para configura el campo siguiente
        //[Display(Name = "Tipo")]

        public int Id { get; set; } //Campo obligatorio, es la clave primaria por defecto
        public string Nombre { get; set; } = string.Empty;
        public string Esoecialidad { get; set; } = string.Empty;
        public int Codigo { get; set; }

    }
}
