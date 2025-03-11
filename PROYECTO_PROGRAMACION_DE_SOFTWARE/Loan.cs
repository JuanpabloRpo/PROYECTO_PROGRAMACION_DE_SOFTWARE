using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Loan
    {
        private int id;
        private Reservation reservation;
        private User user;
        private DateTime startDate;
        private DateTime dueDate;
        private DateTime? returnDate;
        public LoanStatus Status;

        public int Id { get => id; set => id = value; }
        internal Reservation Reservation { get => reservation; set => reservation = value; }
        internal User User { get => user; set => user = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public DateTime? ReturnDate { get => returnDate; set => returnDate = value; }

        public Loan()
        {
        }

        public Loan(int id, User user, DateTime startDate, DateTime dueDate, Reservation reservation, DateTime? returnDate, LoanStatus status)
        {
            Id = id;
            User = user;
            StartDate = startDate;
            DueDate = dueDate;
            ReturnDate = null;
            Status = LoanStatus.Active;
            this.Reservation = reservation;
            ReturnDate = returnDate;
            Status = status;
        }
    }
}
