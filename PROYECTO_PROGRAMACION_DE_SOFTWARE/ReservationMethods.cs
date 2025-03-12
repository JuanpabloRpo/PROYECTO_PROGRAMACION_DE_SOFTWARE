using System;
using System.Collections.Generic;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class ReservationMethods : IReservationManagement
    {
        public void SearchReservation()
        {
            Console.WriteLine("Buscando reserva...");
            List<Reservation> list = GetDataBase.getReservationsDataBase();
            foreach (Reservation reservation in list) 
            {
                if (reservation.Status == ReservationStatus.Pending)
                {
                    Console.WriteLine("-----------------------");
                    reservation.Mostrar();
                    Console.WriteLine("-----------------------");
                }
            }
        }
        public void CreateReservation(Reservation reservation)
        {
            Console.WriteLine("Creando reserva...");

            InsertDataBase.InsertReserve(reservation);
            UpdateDataBase.UpdateMaterialStatusReserved(reservation.Material);
        }
        public void CancelReservation(Reservation reservation)
        {
            Console.WriteLine("Cancelando reserva...");
        }
        public void AcceptReservation(Reservation reservation, User user)
        {
            UpdateDataBase.UpdateReserveaAccepted(reservation);
            InsertDataBase.InsertLoan(new Loan(reservation, user, DateTime.Now, DateTime.Now.AddDays(7)));
            UpdateDataBase.UpdateMaterialStatusLoaned(reservation.Material);
        }
        public void RejectReservation(Reservation reservation)
        {
            UpdateDataBase.UpdateReserveaRejected(reservation);
            UpdateDataBase.UpdateMaterialStatusAvailable(reservation.Material);
        }
    }
}
