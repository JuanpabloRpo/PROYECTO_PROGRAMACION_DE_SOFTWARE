using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class UserManager
    {
        private IUserManagement userMethods;

        public UserManager(IUserManagement userMethods)
        {
            this.userMethods = userMethods;
        }
        public void ShowMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;

            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al gestor de usuarios.");
                Console.WriteLine(
                    "Digite 1 para buscar un usuario\n" +
                    "Digite 2 para crear un usuario\n" +
                    "Digite 3 para actualizar los datos de un usuario\n" +
                    "Digite 4 para eliminar un usuario\n" +
                    "Digite 5 para regresar al menu anterior\n" +
                    "Digite 6 para salir");

                int option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        userMethods.SearchUser();
                        break;
                    case 2:
                        userMethods.CreateUser();
                        break;
                    case 3:
                        userMethods.UpdateUser();
                        break;
                    case 4:
                        userMethods.DeleteUser();
                        break;
                    case 5:
                        Console.WriteLine("Regresando al menu anterior...");
                        flagMenu = false;
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del sistema...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
