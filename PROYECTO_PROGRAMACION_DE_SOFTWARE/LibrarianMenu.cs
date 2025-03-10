using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class LibrarianMenu
    {
        private IMaterialManagement materialMethods;
        private ILoanManagement loanMethods;
        private IReservationManagement reservationMethods;

        public void ShowMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;
            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al sistema de préstamos de la universidad CMD - Bibliotecario - ");
                Console.WriteLine(
                    "Digite 1 para gestionar materiales\n" +
                    "Digite 2 para gestionar préstamos\n" +
                    "Digite 3 para aceptar una reserva\n" +
                    "Digite 4 para rechazar una reserva\n" +
                    "Digite 5 para regresar al menu anterior\n" +
                    "Digite 6 para salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MaterialManager materialManager = new MaterialManager(new MaterialMethods());
                        materialManager.ShowMenu();
                        break;
                    case 2:
                        LoanManager loanManager = new LoanManager();
                        loanManager.ShowMenu();
                        break;
                    case 3:
                        reservationMethods.AcceptReservation();
                        break;
                    case 4:
                        reservationMethods.RejectReservation();
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
