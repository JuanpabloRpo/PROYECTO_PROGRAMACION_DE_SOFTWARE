using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class LibrarianMenu
    {
        public LibrarianMenu() { }
        public void ShowMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;
            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al sistema de préstamos de la universidad CMD");
                Console.WriteLine(
                    "Digite 1 para gestionar materiales\n" +
                    "Digite 2 para gestionar préstamos\n" +
                    "Digite 3 para gestionar reservas\n" +
                    "Digite 4 para regresar al menu anterior\n" +
                    "Digite 5 para salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Gestionando materiales...");
                        break;
                    case 2:
                        Console.WriteLine("Gestionando préstamos...");
                        break;
                    case 3:
                        Console.WriteLine("Gestionando reservas...");
                        break;
                    case 4:
                        Console.WriteLine("regresando al menu anterior...");
                        flagMenu = false;
                        break;
                    case 5:
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
