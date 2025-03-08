using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Reservation
    {
        private string _id;
        private User _user;
        private Material _material;
        private DateTime _requestDate;
        private DateTime _expirationDate;
        private ReservationStatus _status;

        public Reservation(string id, User user, Material material, DateTime requestDate, DateTime expirationDate, ReservationStatus status)
        {
            Id = id;
            User = user;
            Material = material;
            RequestDate = requestDate;
            ExpirationDate = expirationDate;
            Status = status;
        }

        public string Id { get => _id; set => _id = value; }
        public DateTime RequestDate { get => _requestDate; set => _requestDate = value; }
        public DateTime ExpirationDate { get => _expirationDate; set => _expirationDate = value; }
        internal User User { get => _user; set => _user = value; }
        internal Material Material { get => _material; set => _material = value; }
        internal ReservationStatus Status { get => _status; set => _status = value; }
    }
}
