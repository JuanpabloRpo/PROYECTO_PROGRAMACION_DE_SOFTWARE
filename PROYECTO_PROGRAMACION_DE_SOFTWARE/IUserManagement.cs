using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class IUserManagement
    {
        public IUserManagement()
        {
            Console.WriteLine("Bienvenido");
            public void CreateUser(User user);
            public void DeleteUser(string id) { }
            public void ModifyUser(string id, Dictionary<string, object> data) { }
    }
    }
}
