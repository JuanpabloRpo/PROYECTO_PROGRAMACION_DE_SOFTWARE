using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    class LoanManager
    {
        private LoanMethods loanMethods;

        public void ShowMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;

            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al gestor de préstamos.");
                Console.WriteLine(
                    "Digite 1 para buscar un préstamo\n" +
                    "Digite 2 para crear préstamo\n" +
                    "Digite 3 para extender un préstamo\n" +
                    "Digite 4 para regresar un préstamo\n" +
                    "Digite 5 para cancelar un préstamo\n" +
                    "Digite 6 para regresar al menu anterior\n" +
                    "Digite 7 para salir");

                int option = int.Parse(validar.eleccionAValidarSinSobrepasar(1, Console.ReadLine(), 6));
                Console.Clear();

                switch (option)
                {
                    case 1:
                        loanMethods.SearchLoan();
                        break;
                    case 2:
                        loanMethods.CreateLoan();
                        break;
                    case 3:
                        loanMethods.ExtendLoan();
                        break;
                    case 4:
                        loanMethods.ReturnMaterial();
                        break;
                    case 5:
                        loanMethods.CancelLoan();
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
