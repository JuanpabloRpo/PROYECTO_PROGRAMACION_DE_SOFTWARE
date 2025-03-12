using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class UserMenu
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
                Console.WriteLine($" - {user.FirstName} {user.LastName} - Bienvenido al sistema de prestamos de la universidad CMD ");
                Console.WriteLine(
                    "Digite 1 para consultar el material disponible\n" +
                    "Digite 2 para Reservar material\n" +
                    "Digite 3 para ver las reservas hechas\n" +
                    "Digite 4 para ver los prestamos hechos\n" +
                    "Digite 5 para renovar un prestamo (Opcion no disponible)\n" +
                    "Digite 6 para regresar al menu anterior\n" +
                    "Digite 7 para salir");

                int opcion = int.Parse(validar.eleccionAValidarSinSobrepasar(1,Console.ReadLine(),7));
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        materialMethods.ViewAvaraibleMaterials();
                        break;
                    case 2:

                        Console.WriteLine("Ingrese el el id del material a reservar:");
                        int idMaterial = int.Parse(validar.eleccionAValidar(1,Console.ReadLine()));

                        Material material = GetDataBase.getMaterialDataBase(idMaterial);
                        if (material != null && material.Status.ToString().Equals("Available"))
                        {
                            reservationMethods.CreateReservation(new Reservation(user, material, DateTime.Now, DateTime.Now.AddDays(3), ReservationStatus.Pending));
                        }
                        else
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("No se pudo hacer la reserva.");
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine($"\nReservas hechas por {user.FirstName} {user.LastName} {user.MiddleName}\n");
                        foreach (Reservation reservation in GetDataBase.getReservationsUserDataBase(user.Id))
                        {
                            reservation.Mostrar();
                            Console.WriteLine("--------------------------------------");
                        }
                        break;
                    case 4:
                        Console.WriteLine($"Prestamos hechos por {user.FirstName} {user.LastName} {user.MiddleName}");
                        user.Reservations = GetDataBase.getReservationsUserDataBase(user.Id);
                        foreach (Loan loan in GetDataBase.getLoansUserDataBase(user.Reservations))
                        {
                            loan.Mostrar();
                        }
                        break;
                    case 5:
                        loanMethods.ExtendLoan();
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
