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

        public Loan(Reservation reservation, User user, DateTime startDate, DateTime dueDate)
        {
            User = user;
            StartDate = startDate;
            DueDate = dueDate;
            ReturnDate = null;
            Status = LoanStatus.Active;
            this.Reservation = reservation;
            ReturnDate = returnDate;
            
        }
        public void Mostrar()
        {
            Console.WriteLine("\n----- Detalles del Préstamo -----\n");
            Console.WriteLine($"ID del préstamo: {id}");
            Console.WriteLine($"ID de la reserva: {reservation.Id}");
            Console.WriteLine($"Material reservado: {reservation.Material.Title}");
            Console.WriteLine($"Nombre del usuario: {user.FirstName} {user.LastName}");
            Console.WriteLine($"Cédula del usuario: {user.Cedula}");
            Console.WriteLine($"Fecha de inicio: {startDate:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Fecha de vencimiento: {dueDate:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Fecha de devolución: {(returnDate.HasValue ? returnDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "No devuelto")}");
            Console.WriteLine($"Estado del préstamo: {Status}");
        }
    }
}
