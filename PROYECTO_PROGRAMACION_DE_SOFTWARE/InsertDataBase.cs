using System;
using System.Data.SqlClient;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class InsertDataBase
    {
        public static SqlConnection connection = new SqlConnection("Server=DESKTOP-UTRTB3P; Database = ProgramacionDataBase; Trusted_Connection=True;");
        public static void InsertUser(User user)
        {
            connection.Open();

            string consulta = $"INSERT INTO NormalUser " +
                $"(userId, firstName, lastName, middleName, age, arrears, email, userName, userPassword, typeUser) " +
                $"VALUES ({user.Id}, '{user.FirstName}', '{user.LastName}', '{user.MiddleName}', {user.Age}, '{user.Arrears}', " +
                $"'{user.Email}', '{user.UserName}', '{user.Password}', '{user.TypeUser.ToString()}')";

            SqlCommand comando = new SqlCommand(consulta, connection);

            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Registro Usuario creado -----\n");
            connection.Close();
        }
        public static void InsertLibrarian(User user)
        {
            connection.Open();
            string consulta = $"INSERT INTO Librarian(librarianId,firstName,lastName,email) VALUES ('{user.FirstName}','{user.LastName}','{user.Email}')";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Registro Bibliotecario creado -----\n");
            connection.Close();
        }
        public static void InsertBook(Book book)
        {
            connection.Open();
            string consulta = $"INSERT INTO Material (materialId, title, author, publicationYear, category, materialType, materialstatus,materialCondition, pageBook) VALUES ({book.Id},'{book.Title}','{book.Author}','{book.YearPublication}',{book.Type},'Book','{book.Status}', {book.Condition} ,{book.Pages})";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Material Libro Guardado -----\n");
            connection.Close();
        }
        public static void InsertAudioVisual(AudioVisual audioVisual)
        {
            connection.Open();
            string consulta = $"INSERT INTO Material (materialId, title, author, publicationYear, category, materialType, materialstatus, pageBook) VALUES ({audioVisual.Id},'{audioVisual.Title}','{audioVisual.Author}','{audioVisual.YearPublication}',{audioVisual.Type},'AudioVisual','{audioVisual.Status}', {audioVisual.Duration},{audioVisual.Format})";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Material Audio Visual Guardado -----\n");
            connection.Close();
        }
        public static void InsertReserve(Reservation reservation)
        {
            connection.Open();
            string consulta = $"INSERT INTO Reservation (userId,materialId,reservationDate,expirationDate,reservationStatus) VALUES({reservation.User.Id},{reservation.Material.Id},{reservation.RequestDate},{reservation.ExpirationDate},{reservation.Status});";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Reserva creada -----\n");
            connection.Close();
        }
        public static void InsertLoan(Loan loan)
        {
            connection.Open();
            string consulta = $"INSERT INTO Loan (reservationId, librarianId, startDate, endDate,returnDate, loanStatus) VALUES({loan.Reservation.Id},{loan.User.Id},'{loan.StartDate}','{loan.ReturnDate}','{loan.Status}');";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Prestamo creado -----\n");
            connection.Close();
        }


    }
}
