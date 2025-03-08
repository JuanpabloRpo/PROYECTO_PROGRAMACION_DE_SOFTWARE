using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class ReservationMethods : IReservationManagement
    {
        public void SearchReservation()
        {
            Console.WriteLine("Buscando reserva...");
        }
        public void CreateReservation()
        {
            Console.WriteLine("Creando reserva...");
        }
        public void CancelReservation()
        {
            Console.WriteLine("Cancelando reserva...");
        }
        public void AcceptReservation()
        {
            Console.WriteLine("Aceptando reserva...");
        }
        public void RejectReservation()
        {
            Console.WriteLine("Rechazando reserva...");
        }
    }
}
