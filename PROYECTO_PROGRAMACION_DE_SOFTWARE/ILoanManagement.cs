using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal interface ILoanManagement
    {
        void CreateLoan();
        void ExtendLoan();
        void ReturnMaterial();
        void CancelLoan();
    }
}
