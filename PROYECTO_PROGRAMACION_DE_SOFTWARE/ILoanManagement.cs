using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class ILoanManagement
    {
        public ILoanManagement()
        {
            Console.WriteLine("Bienvenido");
            Loan CreateLoan(User user, Material material);
            bool ExtendLoan(Loan loan, DateTime newDueDate);
            void ReturnMaterial(Loan loan);
            void CancelLoan(Loan loan);
        }
    }
}
