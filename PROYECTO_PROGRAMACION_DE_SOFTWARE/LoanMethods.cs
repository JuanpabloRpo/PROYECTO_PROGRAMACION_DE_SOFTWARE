using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class LoanMethods : ILoanManagement
    {
        public void CreateLoan()
        {
            Console.WriteLine("Creando préstamo...");
        }
        public void ExtendLoan()
        {
            Console.WriteLine("Extendiendo préstamo...");
        }
        public void ReturnMaterial()
        {
            Console.WriteLine("Devolviendo material...");
        }
        public void CancelLoan()
        {
            Console.WriteLine("Cancelando préstamo...");
        }
    }
}
