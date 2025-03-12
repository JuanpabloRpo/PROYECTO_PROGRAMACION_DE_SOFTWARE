using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class LibrarianMenu
    {
        private MaterialMethods materialMethods = new MaterialMethods();
        private LoanMethods loanMethods = new LoanMethods();
        private ReservationMethods reservationMethods = new ReservationMethods();

        public void ShowMenu(User user)
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;
            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al sistema de préstamos de la universidad CMD - Bibliotecario - ");
                Console.WriteLine(
                    "Digite 1 para gestionar materiales (Opcion no disponible)\n" +
                    "Digite 2 para gestionar préstamos (Opcion no disponible)\n" +
                    "Digite 3 para ver reservas pendientes\n" +
                    "Digite 4 para Aceptar o rechazar una reserva\n" +
                    "Digite 5 para regresar al menu anterior\n" +
                    "Digite 6 para salir");

                int opcion = int.Parse(validar.eleccionAValidarSinSobrepasar(1,Console.ReadLine(),6));

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
                        reservationMethods.SearchReservation();
                        break;
                    case 4:

                        Console.WriteLine("Ingrese el id de la reserva: ");
                        int data = int.Parse(validar.eleccionAValidar(1,Console.ReadLine()));

                        Reservation reservation = GetDataBase.getReservationDataBase(data);

                        if (reservation == null)
                        {
                            Console.WriteLine("No se encontro la reserva");
                            break;
                        }

                        Console.WriteLine("digite 1 para aceptar o 2 para rechazar");

                        int reservaOpcion = int.Parse(validar.eleccionAValidarSinSobrepasar(1, Console.ReadLine(), 2));

                        if (reservaOpcion == 1)
                        {
                            reservationMethods.AcceptReservation(reservation,user);
                        }
                        else if (reservaOpcion == 2)
                        {
                            reservationMethods.RejectReservation(reservation);
                        }
                        else
                        {
                            Console.WriteLine("Opcion invalida");
                        }
                        
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
