using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class AdministratorMenu
    {
        public AdministratorMenu() { }
        public void ShowMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;

            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al sistema de prestamos de la universidad CMD");
                Console.WriteLine(
                    "Digite 1 para gestionar materiales\n" +
                    "Digite 2 para gestionar préstamos\n" +
                    "Digite 3 para gestionar reservas\n" +
                    "Digite 4 para gestionar usuarios\n" +
                    "Digite 5 para regresar al menu anterior\n" +
                    "Digite 6 para salir");

                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        MaterialManager materialManager = new MaterialManager(new MaterialMethods());
                        materialManager.ShowMenu();
                        break;
                    case 2:
                        LoanManager loanManager = new LoanManager(new LoanMethods());
                        loanManager.ShowMenu();
                        break;
                    case 3:
                        ReservationManager reservationManager = new ReservationManager(new ReservationMethods());
                        reservationManager.ShowMenu();
                        break;
                    case 4:
                        UserManager userManager = new UserManager(new UserMethods());
                        userManager.ShowMenu();
                        break;
                    case 5:
                        Console.WriteLine("regresando al menu anterior...");
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