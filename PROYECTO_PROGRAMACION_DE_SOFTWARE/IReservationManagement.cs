using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class IReservationManagement
    {
        public IReservationManagement()
        {
            Console.WriteLine("Bienvenido");
            void CreateReservation(User user, Material material);
            void AcceptReservation(string reservationId);
            void RejectReservation(string reservationId);
            void CancelReservation(string reservationId);
            List<Reservation> GetUserReservations(User user);
        }
    }
}
