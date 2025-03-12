using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class User: Person
    {
        private string email;
        private string userName;
        private string password;
        private int arrears;
        private TypeUser typeUser;
        private List<Reservation> reservations;
        private List<Loan> loans;

        public User()
        {
        }

        public User(int cedula, string name, string apellidoPaterno, string apellidoMaterno,
            int edad, string email, string userName, string password, int arrears, TypeUser typeUser) 
            : base(cedula, name, apellidoPaterno, apellidoMaterno, edad)

        {
            this.email = email;
            this.userName = userName; 
            this.Password = password;
            this.Arrears = arrears;
            this.typeUser = typeUser;   

        }

        public string Email { get => email; set => email = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Arrears { get => arrears; set => arrears = value; }
        internal TypeUser TypeUser { get => typeUser; set => typeUser = value; }
        internal List<Reservation> Reservations { get => reservations; set => reservations = value; }
        internal List<Loan> Loans { get => loans; set => loans = value; }
    }
}
