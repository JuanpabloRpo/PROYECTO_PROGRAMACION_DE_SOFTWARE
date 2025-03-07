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
            Console.WriteLine("Ingrese el ID del usuario a buscar:");
            int id = int.Parse(Console.ReadLine());
            User user = DataBase.Search(id);
            if (user == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return;
            }
            Console.WriteLine("ID: " + user.Id);
            Console.WriteLine("Email: " + user.Email);
            Console.WriteLine("Nombre de usuario: " + user.UserName);
        }
        public void CreateUser()
        {
            User newUser = SignUp.CreateUser();
            Console.WriteLine("Usuario creado exitosamente.");
        }

        public void UpdateUser()
        {
            Console.WriteLine("Ingrese el ID del usuario a actualizar:");
            int id = int.Parse(Console.ReadLine());
                
            User user = DataBase.Update(id);
            if (user == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return;
            }

            Console.WriteLine("Ingrese el nuevo email:");
            user.Email = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo nombre de usuario:");
            user.UserName = Console.ReadLine();

            Console.WriteLine("Datos actualizados correctamente.");
        }

        public void DeleteUser()
        {
            Console.WriteLine("Ingrese el ID del usuario a eliminar:");
            int id = int.Parse(Console.ReadLine());

            if (DataBase.Delet(id))
            {
                Console.WriteLine("Usuario eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró el usuario.");
            }
        }
    }
}
