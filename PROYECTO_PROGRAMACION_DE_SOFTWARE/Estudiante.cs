using System;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Estudiante: Persona
    {
        private string _facultad;
        private bool _morosidad;
        private int _carnet;

        public string Facultad { get => _facultad; set => _facultad = value; }
        public bool Reportado { get => _morosidad; set => _morosidad = value; }
        public int Carnet { get => _carnet; set => _carnet = value; }

        public Estudiante(int id, string name, string apellidoPaterno, string apellidoMaterno, int edad, bool activo, string facultad, bool moriosidad, int carnet) : base(id, name, apellidoPaterno, apellidoMaterno, edad, activo)
        {
            _facultad = facultad;
            _morosidad = moriosidad;
            Carnet = carnet;
        }

        public Estudiante()
        {
        }

    }
}
