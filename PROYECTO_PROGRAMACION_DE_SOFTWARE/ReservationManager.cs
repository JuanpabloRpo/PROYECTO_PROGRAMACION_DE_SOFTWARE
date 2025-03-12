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
            Reservation reservation = new Reservation();
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

                int option = int.Parse(validar.eleccionAValidarSinSobrepasar(1,Console.ReadLine(),6));
                Console.Clear();

                switch (option)
                {
                    case 1:
                        reservationMethods.SearchReservation();
                        break;
                    case 2:
                        
                        reservationMethods.CreateReservation( reservation);
                        break;
                    case 3:
                        reservationMethods.CancelReservation(reservation);
                        break;
                    case 4:
                        reservationMethods.AcceptReservation(reservation, new User());
                        break;
                    case 5:
                        reservationMethods.RejectReservation(reservation);
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
