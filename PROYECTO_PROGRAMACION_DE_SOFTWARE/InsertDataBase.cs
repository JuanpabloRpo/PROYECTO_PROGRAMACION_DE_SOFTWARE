using System;
using System.Data.SqlClient;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class InsertDataBase
    {
        public static SqlConnection connection = new SqlConnection("Server=DESKTOP-UTRTB3P; Database = EjercicioProgramacion; Trusted_Connection=True;");
        public static void InsertUser(User user)
        {
            connection.Open();
            string consulta = $"INSERT INTO NormalUser(userId,firstName,lastName,middleName,age,isInDebt,email,username,userPassword,typeUser) VALUES ({user.Id},'{user.FirstName}','{user.LastName}','{user.MiddleName}',{user.Age},{user.Arrears},'{user.Email}','{user.UserName}','{user.Password}','{user.TypeUser.ToString()}' )";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Registro creado -----\n");
            connection.Close();
        }
        public static void InsertBook(Book book)
        {
            connection.Open();
            string consulta = $"INSERT INTO Material (materialId, title, author, publicationYear, category, materialType, materialstatus, pageBook) VALUES ({book.Id},'{book.Title}','{book.Author}','{book.YearPublication}',{book.Type},'Book','{book.Status}', {book.Pages})";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Material Guardado -----\n");
            connection.Close();
        }

        public static void InsertReserve(User user, Material material, DateTime date)
        {
            connection.Open();
            string consulta = $"INSERT INTO Reservation (userId,materialId,reservationDate,reservationStatus) VALUES({user.Id.ToString()},{material.Id},{date});";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Registro creado -----\n");
            connection.Close();
        }
        public static void InsertAudioVisual(AudioVisual Audiovisual)
        {
            connection.Open();
            string consulta = $"INSERT INTO Material (materialId, title, author, publicationYear, category, materialType, materialstatus, pageBook) VALUES ({Audiovisual.Id},'{Audiovisual.Title}','{Audiovisual.Author}','{Audiovisual.YearPublication}',{Audiovisual.Type},'Audiovisual','{Audiovisual.Status}', {Audiovisual.Duration})";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("\n----- Material Guardado -----\n");
            connection.Close();
        }
    }
}
