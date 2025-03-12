using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class UpdateDataBase
    {
        private static string connectionString = "Server=DESKTOP-UTRTB3P; Database=ProgramacionDataBase; Trusted_Connection=True;";
        public static void UpdateReserveaAccepted(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"UPDATE Reservation SET reservationStatus = 'Accepted' WHERE reservationId = {reservation.Id}";
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateReserveaRejected(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"UPDATE Reservation SET reservationStatus = 'Rejected' WHERE reservationId = {reservation.Id}";
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateReserveaCanceled(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"UPDATE Reservation SET reservationStatus = 'Canceled' WHERE reservationId = {reservation.Id}";
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateReserveaExpired(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"UPDATE Reservation SET reservationStatus = 'Expired' WHERE reservationId = {reservation.Id}";
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateMaterialStatusAvailable(Material material)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"UPDATE Material SET materialstatus = 'Available' WHERE materialId = {material.Id}";
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateMaterialStatusReserved(Material material)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"UPDATE Material SET materialstatus = 'Reserved' WHERE materialId = {material.Id}";
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateMaterialStatusLoaned(Material material)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"UPDATE Material SET materialstatus = 'Loaned' WHERE materialId = {material.Id}";
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }

    }
}
