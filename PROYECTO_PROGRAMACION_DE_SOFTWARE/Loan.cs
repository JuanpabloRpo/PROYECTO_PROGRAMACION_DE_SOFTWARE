using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Loan
    {
        private string Id;
        private User User;
        private Material Material;
        private DateTime StartDate;
        private DateTime DueDate;
        private DateTime? ReturnDate;
        private LoanStatus Status;

        public Loan(string id, User user, Material material, DateTime startDate, DateTime dueDate)
        {
            Id = id;
            User = user;
            Material = material;
            StartDate = startDate;
            DueDate = dueDate;
            ReturnDate = null;
            Status = LoanStatus.Active;
        }
    }
}
