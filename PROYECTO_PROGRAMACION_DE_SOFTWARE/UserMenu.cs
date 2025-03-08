using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class UserMenu
    {
        private IMaterialManagement materialMethods;
        private ILoanManagement loanMethods;
        private IReservationManagement reservationMethods;

        public UserMenu(IMaterialManagement materialMethods, ILoanManagement loanMethods, IReservationManagement reservationMethods)
        {
            this.materialMethods = materialMethods;
            this.loanMethods = loanMethods;
            this.reservationMethods = reservationMethods;
        }

        public void ShowMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;

            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al sistema de prestamos de la universidad CMD");
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
