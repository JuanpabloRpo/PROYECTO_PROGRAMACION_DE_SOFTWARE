using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;

using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class GetDataBase
    {
        public static SqlConnection connection = new SqlConnection("Server=DESKTOP-UTRTB3P; Database = ProgramacionDataBase; Trusted_Connection=True;");
        public static User getUserDataBase(string UserName)
        {
            connection.Open();
            string consulta = "select * from NormalUser";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            User user = null;
            while (lector.Read())
            {
                if (lector["userName"].ToString().Equals(UserName))
                {
                    user = new User();
                    user.Id = int.Parse(lector["userId"].ToString());
                    user.FirstName = lector["firstName"].ToString();
                    user.LastName = lector["lastName"].ToString();
                    user.MiddleName = lector["middleName"].ToString();
                    user.Age = int.Parse(lector["age"].ToString());
                    user.Arrears = int.Parse(lector["arrears"].ToString());
                    user.Email = lector["email"].ToString();
                    user.UserName = lector["userName"].ToString();
                    user.Password = lector["userPassword"].ToString();
                    user.TypeUser = (TypeUser)Enum.Parse(typeof(TypeUser), lector["typeUser"].ToString());
                    break;
                }
            }
            connection.Close();
            return user;

        }
        public static User getUserDataBase(int id)
        {
            connection.Open();
            string consulta = "select * from NormalUser";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            User user = null;
            while (lector.Read())
            {
                if (int.Parse(lector["userId"].ToString()) == id)
                {
                    user = new User();
                    user.Id = int.Parse(lector["userId"].ToString());
                    user.FirstName = lector["firstName"].ToString();
                    user.LastName = lector["lastName"].ToString();
                    user.MiddleName = lector["middleName"].ToString();
                    user.Age = int.Parse(lector["age"].ToString());
                    user.Arrears = int.Parse(lector["arrears"].ToString());
                    user.Email = lector["email"].ToString();
                    user.UserName = lector["userName"].ToString();
                    user.Password = lector["userPassword"].ToString();
                    user.TypeUser = (TypeUser)Enum.Parse(typeof(TypeUser), lector["typeUser"].ToString());
                    break;
                }
            }
            connection.Close();
            return user;

        }
        public static Book getBookDataBase(int bookId)
        {
            connection.Open();
            string consulta = "SELECT * FROM Material WHERE materialType = 'Book'";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            Book book = null;
            while (lector.Read())
            {
                if (int.Parse(lector["materialId"].ToString()) == bookId)
                {
                    book = new Book();
                    book.Id = int.Parse(lector["materialId"].ToString());
                    book.Title = lector["title"].ToString();
                    book.Author = lector["author"].ToString();
                    book.YearPublication = int.Parse(lector["publicationYear"].ToString());
                    book.Type = MaterialType.FromString(lector["category"].ToString());
                    book.Status = (MaterialStatus)Enum.Parse(typeof(MaterialStatus), lector["materialstatus"].ToString());
                    book.Condition = (MaterialCondition)Enum.Parse(typeof(MaterialCondition), lector["materialCondition"].ToString());
                    book.Pages = int.Parse(lector["pageBook"].ToString());
                    break;
                }
            }
            connection.Close();
            return book;
        }
        public static List<Book> getBooksDataBase()
        {
            connection.Open();
            string consulta = "SELECT * FROM Material WHERE materialType = 'Book'";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            
            List<Book> books = new List<Book>();

            while (lector.Read())
            {
                
                if (lector["materialType"].ToString().Equals("Book"))
                {
                    Book book = new Book();

                    book.Id = int.Parse(lector["materialId"].ToString());
                    book.Title = lector["title"].ToString();
                    book.Author = lector["author"].ToString();
                    book.YearPublication = int.Parse(lector["publicationYear"].ToString());
                    book.Type = MaterialType.FromString(lector["category"].ToString());
                    book.Status = (MaterialStatus)Enum.Parse(typeof(MaterialStatus), lector["materialstatus"].ToString());
                    book.Condition = (MaterialCondition)Enum.Parse(typeof(MaterialCondition), lector["materialCondition"].ToString());
                    book.Pages = int.Parse(lector["pageBook"].ToString());
                    
                    books.Add(book);
                }
                
                   
            }
            connection.Close();
            return books;
        }
        public static AudioVisual getAudioVisualDataBase(int audiovisualId)
        {
            connection.Open();
            string consulta = "SELECT * FROM Material WHERE materialType = 'AudioVisual'";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            AudioVisual audioVisual = null;
            while (lector.Read())
            {
                if (int.Parse(lector["materialId"].ToString()) == audiovisualId)
                {
                    audioVisual = new AudioVisual();
                    audioVisual.Id = int.Parse(lector["materialId"].ToString());
                    audioVisual.Title = lector["title"].ToString();
                    audioVisual.Author = lector["author"].ToString();
                    audioVisual.YearPublication = int.Parse(lector["publicationYear"].ToString());
                    audioVisual.Type = MaterialType.FromString(lector["category"].ToString());
                    audioVisual.Status = (MaterialStatus)Enum.Parse(typeof(MaterialStatus), lector["materialstatus"].ToString());
                    audioVisual.Condition = (MaterialCondition)Enum.Parse(typeof(MaterialCondition), lector["materialCondition"].ToString());
                    audioVisual.Format = lector["formato"].ToString();
                    audioVisual.Duration = lector["duration"].ToString();
                    break;
                }
            }
            connection.Close();
            return audioVisual;

        }
        public static List<AudioVisual> getAudioVisualsDataBase()
        {
            connection.Open();
            string consulta = "SELECT * FROM Material WHERE materialType = 'AudioVisual'";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            
            List<AudioVisual> audioVisuals = new List<AudioVisual>();
            while (lector.Read())
            {
                if (lector["materialType"].ToString().Equals("AudioVisual"))
                {
                    AudioVisual audioVisual = new AudioVisual();

                    audioVisual.Id = int.Parse(lector["materialId"].ToString());
                    audioVisual.Title = lector["title"].ToString();
                    audioVisual.Author = lector["author"].ToString();
                    audioVisual.YearPublication = int.Parse(lector["publicationYear"].ToString());
                    audioVisual.Type = MaterialType.FromString(lector["category"].ToString());
                    audioVisual.Status = (MaterialStatus)Enum.Parse(typeof(MaterialStatus), lector["materialstatus"].ToString());
                    audioVisual.Condition = (MaterialCondition)Enum.Parse(typeof(MaterialCondition), lector["materialCondition"].ToString());
                    audioVisual.Format = lector["formato"].ToString();
                    audioVisual.Duration = lector["duration"].ToString();

                    audioVisuals.Add(audioVisual);
                }

            }
            connection.Close();
            return audioVisuals;

        }
        public static Material getMaterialDataBase(int materialId)
        {

            Material material = null;
            if (!string.IsNullOrEmpty(getBookDataBase(materialId).Id.ToString()))
            {
                material = getBookDataBase(materialId);

            }
            else if (!string.IsNullOrEmpty(getAudioVisualDataBase(materialId).Id.ToString()))
            {
                material = getAudioVisualDataBase(materialId);
            }
            else 
            {
                Console.WriteLine("no se encontró el material.");
            }

            return material;
        }
        public static List<Material> getMaterialsDataBase()
        {

            List<Material> materials = new List<Material>();
            foreach (Book book in getBooksDataBase())
            {
                materials.Add(book);
            }

            foreach (AudioVisual audioVisual in getAudioVisualsDataBase())
            {
                materials.Add(audioVisual);
            }

            return materials;
        }
        public static Reservation getReservationDataBase(int userId)
        {
            connection.Open();
            string consulta = "SELECT * FROM Reservation";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            Reservation reservation = null;
            while (lector.Read())
            {
                if (int.Parse(lector["userId"].ToString()) == userId)
                {
                    reservation = new Reservation();
                    reservation.Id = int.Parse(lector["reservationId"].ToString());
                    reservation.User = getUserDataBase(int.Parse(lector["userId"].ToString()));
                    reservation.Material = getMaterialDataBase(int.Parse(lector["materialId"].ToString())) ;
                    reservation.RequestDate = DateTime.Parse(lector["requestDate"].ToString());
                    reservation.ExpirationDate = DateTime.Parse(lector["expirationDate"].ToString());
                    reservation.Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), lector["reservationStatus"].ToString());
                    break;
                }
            }
            connection.Close();
            return reservation;

        }
        public static Loan getLoantaBase(int reservationId)
        {
            connection.Open();
            string consulta = "SELECT * FROM Loan";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            Loan loan = null;
            while (lector.Read())
            {
                if (int.Parse(lector["reservationId"].ToString()) == reservationId)
                {
                    loan = new Loan();
                    loan.Id = int.Parse(lector["loanId"].ToString());
                    loan.Reservation = getReservationDataBase(int.Parse(lector["reservationId"].ToString()));
                    loan.User = getUserDataBase(int.Parse(lector["librarianId"].ToString()));
                    loan.StartDate = DateTime.Parse(lector["startDate"].ToString());
                    loan.DueDate = DateTime.Parse(lector["endDate"].ToString());
                    loan.ReturnDate = DateTime.Parse(lector["returnDate"].ToString());
                    loan.Status = (LoanStatus)Enum.Parse(typeof(LoanStatus), lector["loanStatus"].ToString());
                    break;
                }
            }
            connection.Close();
            return loan;

        }

    }
}
