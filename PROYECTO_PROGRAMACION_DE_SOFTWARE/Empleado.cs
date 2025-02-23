using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Empleado: Persona
    {
        private string _tipoEmpleado; // Bibliotecario, De admiciones, Administrador, etc...
        private int _sueldo;

        public Empleado()
        {
        }

        public Empleado(int id, string name, string apellidoPaterno, string apellidoMaterno, int edad, bool activo,string tipoEmpleado,int sueldo) : base(id, name, apellidoPaterno, apellidoMaterno, edad, activo)
        {
            _tipoEmpleado = tipoEmpleado;
            _sueldo = sueldo;
        }

        public string TipoEmpleado { get => _tipoEmpleado; set => _tipoEmpleado = value; }
        public int Sueldo { get => _sueldo; set => _sueldo = value; }
    }
}
