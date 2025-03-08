using System;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal abstract class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }

        public Person()
        {
        }

        public Person(int id, string name, string apellidoPaterno, string apellidoMaterno, int edad)
        {
            Id = id;
            FirstName = name;
            LastName = apellidoPaterno;
            MiddleName = apellidoMaterno;
            Age = edad;
        }
    }
}
