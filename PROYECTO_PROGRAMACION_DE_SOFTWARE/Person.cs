using System;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal abstract class Person
    {

        private int _Id;
        private string _Name;
        private string _ApellidoPaterno;
        private string _ApellidoMaterno;
        private int _Edad;

        public Person()
        {
        }

        public Person(int id, string name, string apellidoPaterno, string apellidoMaterno, int edad)
        {
            _Id = id;
            _Name = name;
            _ApellidoPaterno = apellidoPaterno;
            _ApellidoMaterno = apellidoMaterno;
            _Edad = edad;
        }

        public int Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string ApellidoPaterno { get => _ApellidoPaterno; set => _ApellidoPaterno = value; }
        public string ApellidoMaterno { get => _ApellidoMaterno; set => _ApellidoMaterno = value; }
        public int Edad { get => _Edad; set => _Edad = value; }
    }
}
