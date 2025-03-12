using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class InsertDataBase
    {
        private static string connectionString = "Server=DESKTOP-UTRTB3P; Database=ProgramacionDataBase; Trusted_Connection=True;";
        public static void InsertUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"INSERT INTO NormalUser " +
                    "( cedula,firstName, lastName, middleName, age, arrears, email, userName, userPassword, typeUser) " +
                    $"VALUES ({user.Cedula}, '{user.FirstName}', '{user.LastName}', '{user.MiddleName}', {user.Age}, '{user.Arrears}', " +
                    $"'{user.Email}', '{user.UserName}', '{user.Password}', '{user.TypeUser.ToString()}')";

                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
                Thread.Sleep(3000);
                Console.WriteLine("\n----- Registro Usuario creado -----\n");
            }
        }
        public static void InsertLibrarian(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"INSERT INTO Librarian(librarianId,userId,firstName,lastName,email) " +
                    $"VALUES ({user.Id},'{user.FirstName}','{user.LastName}','{user.Email}')";

                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
                Thread.Sleep(3000);
                Console.WriteLine("\n----- Registro Bibliotecario creado -----\n");
            }
        }
        public static void InsertBook(Book book)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"INSERT INTO Material (materialId, title, author, publicationYear, category, materialType, materialstatus,materialCondition, pageBook) " +
                    $"VALUES ({book.Id},'{book.Title}','{book.Author}','{book.YearPublication}','{book.Type.ToString()}','Book','{book.Status.ToString()}', " +
                    $"'{book.Condition.ToString()}' ,{book.Pages})";

                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
                Thread.Sleep(3000);
                Console.WriteLine("\n----- Material Libro Guardado -----\n");
            }
        }
        public static void InsertAudioVisual(AudioVisual audioVisual)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string consulta = $"INSERT INTO Material (materialId, title, author, publicationYear, category, materialType, materialstatus, pageBook) " +
                    $"VALUES ({audioVisual.Id},'{audioVisual.Title}','{audioVisual.Author}','{audioVisual.YearPublication}','{audioVisual.Type.ToString()}'," +
                    $"'AudioVisual','{audioVisual.Status.ToString()}', {audioVisual.Duration},{audioVisual.Format})";

                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
                Thread.Sleep(3000);
                Console.WriteLine("\n----- Material Audio Visual Guardado -----\n");
            }
        }
        public static void InsertReserve(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string formatRequestDate = reservation.RequestDate.ToString("yyyy-MM-dd HH:mm:ss");
                string formatExpirationDate = reservation.ExpirationDate.ToString("yyyy-MM-dd HH:mm:ss");

                string consulta = $"INSERT INTO Reservation (userId,materialId,requestDate,expirationDate,reservationStatus) " +
                    $"VALUES({reservation.User.Id},{reservation.Material.Id},'{formatRequestDate}'," +
                    $"'{formatExpirationDate}','{reservation.Status.ToString()}');";

                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
                Thread.Sleep(3000);
                Console.WriteLine("\n----- Reserva creada -----\n");
            }
        }
        public static void InsertLoan(Loan loan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string formatStartDate = loan.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
                string formatDueDate = loan.DueDate.ToString("yyyy-MM-dd HH:mm:ss");
                string consulta = $"INSERT INTO Loan (reservationId, librarianId, startDate, endDate) " +
                    $"VALUES({loan.Reservation.Id},{loan.User.Id},'{formatStartDate}'," +
                    $"'{formatDueDate}');";

                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.ExecuteNonQuery();
                }
                Thread.Sleep(3000);
                Console.WriteLine("\n----- Préstamo creado -----\n");
            }
        }

    }
}
