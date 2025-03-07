using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class AdministratorMenu
    {
        public AdministratorMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;
            while (flagMenu)
            {
                int opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Bienvenido al sistema de prestamos de la universidad CMD");
                Console.WriteLine(
                    "Digite 1 para gestionar materiales\n" +
                    "Digite 2 para gestionar préstamos\n" +
                    "Digite 3 para gestionar reservas\n" +
                    "Digite 4 para gestionar usuarios\n" +
                    "Digite 5 para salir");

                switch (opcion)
                {
                    case 1:
                        IMaterialManagement IMaterialManagement = new IMaterialManagement();
                        break;
                    case 2:
                        ILoanManagement ILoanManagement = new ILoanManagement();
                        break;
                    case 3:
                        IReservationManagement IReservationManagement = new IReservationManagement();
                        break;
                    case 4:
                        IUserManagement IUserManagement = new IUserManagement();
                        break;
                    case 5:
                        flagMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
    }
}