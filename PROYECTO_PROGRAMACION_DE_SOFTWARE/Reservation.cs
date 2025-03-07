using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Reservation
    {
        private string Id;
        private User User;
        private Material Material;
        private DateTime RequestDate;
        private DateTime ExpirationDate;
        private ReservationStatus Status;

        public Reservation(string id, User user, Material material, DateTime requestDate, int validDays)
        {
            Id = id;
            User = user;
            Material = material;
            RequestDate = requestDate;
            ExpirationDate = requestDate.AddDays(validDays);
            Status = ReservationStatus.Pending;
        }
    }
}
