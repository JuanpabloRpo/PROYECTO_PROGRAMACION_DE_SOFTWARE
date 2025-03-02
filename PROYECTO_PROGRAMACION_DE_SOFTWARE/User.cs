using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal abstract class User: Person
    {
        private string email;
        private string userName;
        private string password;
        private bool arrears;

        protected User()
        {
        }

        protected User(int id, string name, string apellidoPaterno, string apellidoMaterno, int edad, bool activo, string email, string userName, string password, bool arrears) : base(id, name, apellidoPaterno, apellidoMaterno, edad, activo)

        {
            this.email = email;
            this.userName = userName; 
            this.password = password;
            this.arrears = arrears;

        }

        public abstract string ViewProfile();
        public abstract void UpdateData(Dictionary<string, object> NewData);
    }
}
