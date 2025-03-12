using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal interface IReservationManagement
    {
        void SearchReservation();
        void CreateReservation(Reservation reservation);
        void AcceptReservation(Reservation reservation, User user);
        void RejectReservation(Reservation reservation);
        void CancelReservation(Reservation reservation);
    }
}
