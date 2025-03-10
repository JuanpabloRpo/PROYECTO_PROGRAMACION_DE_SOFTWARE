using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    class ReservationManager
    {
        private ReservationMethods reservationMethods;
        
        public void ShowMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;

            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al gestor de reservas.");
                Console.WriteLine(
                    "Digite 1 para buscar una reserva\n" +
                    "Digite 2 para hacer una reserva\n" +
                    "Digite 3 para cancelar una reserva\n" +
                    "Digite 4 para aceptar una reserva\n" +
                    "Digite 5 para rechazar una reserva\n" +
                    "Digite 6 para regresar al menu anterior\n" +
                    "Digite 7 para salir");

                int option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        reservationMethods.SearchReservation();
                        break;
                    case 2:
                        reservationMethods.CreateReservation();
                        break;
                    case 3:
                        reservationMethods.CancelReservation();
                        break;
                    case 4:
                        reservationMethods.AcceptReservation();
                        break;
                    case 5:
                        reservationMethods.RejectReservation();
                        break;
                    case 6:
                        Console.WriteLine("Regresando al menu anterior...");
                        flagMenu = false;
                        break;
                    case 7:
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
