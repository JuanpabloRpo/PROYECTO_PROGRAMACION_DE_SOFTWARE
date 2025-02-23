using System;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Docente: Persona
    {
        private string _tipoDocente; // Docente de planta, Docente de catedra
        private int _sueldo;

        public Docente()
        {
        }

        public Docente(int id, string name, string apellidoPaterno, string apellidoMaterno, int edad, bool activo, string tipoDocente, int sueldo) : base(id, name, apellidoPaterno, apellidoMaterno, edad, activo)
        {
            _tipoDocente = tipoDocente;
            Sueldo = sueldo;
        }

        public string TipoDocente { get => _tipoDocente; set => _tipoDocente = value; }
        public int Sueldo { get => _sueldo; set => _sueldo = value; }
    }
}
