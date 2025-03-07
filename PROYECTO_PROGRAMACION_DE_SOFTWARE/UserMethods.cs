using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class UserMethods : IUserManagement
    {
        public void SearchUser()
        {
            Console.WriteLine("Buscando usuario...");
        }
        public void CreateUser()
        {
            User newUser = SignUp.CreateUser();
            Console.WriteLine("Usuario creado exitosamente.");
        }

        public void UpdateUser()
        {
            Console.WriteLine("Actualizando usuario...");
        }

        public void DeleteUser()
        {
            Console.WriteLine("Eliminando usuario...");
        }
    }
}
