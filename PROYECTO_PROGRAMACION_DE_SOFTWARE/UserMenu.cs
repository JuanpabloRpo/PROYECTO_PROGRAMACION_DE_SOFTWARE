using System;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class UserMenu
    {
        private MaterialMethods materialMethods;
        private LoanMethods loanMethods;
        private ReservationMethods reservationMethods;

        public void ShowMenu(User user)
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;

            while (flagMenu)
            {
                Console.WriteLine($" - {user.FirstName} {user.LastName} - Bienvenido al sistema de prestamos de la universidad CMD ");
                Console.WriteLine(
                    "Digite 1 para consultar el material disponible:\n" +
                    "Digite 2 para Reservar material\n" +
                    "Digite 3 para ver el estado de algun prestamo\n" +
                    "Digite 4 para renovar un prestamo\n"+
                    "Digite 5 para regresar al menu anterior\n" +
                    "Digite 6 para salir");

                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        materialMethods.ViewAvaraibleMaterials();
                        break;
                    case 2:
                        reservationMethods.CreateReservation();
                        break;
                    case 3:
                        loanMethods.SearchLoan();
                        break;
                    case 4:
                        loanMethods.ExtendLoan();
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
