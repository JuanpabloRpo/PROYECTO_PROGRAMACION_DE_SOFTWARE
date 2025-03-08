using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    class LoanManager
    {
        private ILoanManagement loanMethods;

        public LoanManager(ILoanManagement loanMethods)
        {
            this.loanMethods = loanMethods;
        }
        public void ShowMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;

            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al gestor de préstamos.");
                Console.WriteLine(
                    "Digite 1 para crear préstamo\n" +
                    "Digite 2 para extender un préstamo\n" +
                    "Digite 3 para regresar un préstamo\n" +
                    "Digite 4 para cancelar un préstamo\n" +
                    "Digite 5 para regresar al menu anterior\n" +
                    "Digite 6 para salir");

                int option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        loanMethods.CreateLoan();
                        break;
                    case 2:
                        loanMethods.ExtendLoan();
                        break;
                    case 3:
                        loanMethods.ReturnMaterial();
                        break;
                    case 4:
                        loanMethods.CancelLoan();
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
