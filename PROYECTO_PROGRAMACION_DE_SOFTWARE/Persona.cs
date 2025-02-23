using System;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Persona
    {

        private int id;
        private string name;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private int edad;
        private bool activo;

        public Persona()
        {
        }

        public Persona(int id, string name, string apellidoPaterno, string apellidoMaterno, int edad, bool activo)
        {
            this.id = id;
            this.name = name;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.edad = edad;
            this.activo = activo;
        }

        protected int Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }
        protected string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        protected string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        protected int Edad { get => edad; set => edad = value; }
        protected bool Activo { get => activo; set => activo = value; }


    }
}
