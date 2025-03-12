using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class GetDataBase
    {
        
        private static string connectionString = "Server=DESKTOP-UTRTB3P; Database=ProgramacionDataBase; Trusted_Connection=True;";
        public static User getUserDataBase(string UserName)
        {
            User user = null;
            string consulta = "SELECT * FROM NormalUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        if (lector["userName"].ToString().Equals(UserName))
                        {
                            user = new User();
                            user.Id = int.Parse(lector["userId"].ToString());
                            user.Cedula = int.Parse(lector["cedula"].ToString());
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
                }
            }
            return user;
        }

        public static User getUserDataBase(int data)
        {
            User user = null;
            string consulta = "SELECT * FROM NormalUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        if (int.Parse(lector["cedula"].ToString()) == data || int.Parse(lector["userId"].ToString()) == data)
                        {
                            user = new User();
                            user.Id = int.Parse(lector["userId"].ToString());
                            user.Cedula = int.Parse(lector["cedula"].ToString());
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
                }
            }
            return user;
        }
        public static Book getBookDataBase(int bookId)
        {
            Book book = null;
            string consulta = "SELECT * FROM Material WHERE materialType = 'Book'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
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
                }
            }
            return book;
        }
        public static List<Book> getBooksDataBase()
        {
            List<Book> books = new List<Book>();
            string consulta = "SELECT * FROM Material WHERE materialType = 'Book'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
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
                }
            }
            return books;
        }
        public static AudioVisual getAudioVisualDataBase(int audiovisualId)
        {
            AudioVisual audioVisual = null;
            string consulta = "SELECT * FROM Material WHERE materialType = 'AudioVisual'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
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
                }
            }
            return audioVisual;
        }
        public static List<AudioVisual> getAudioVisualsDataBase()
        {
            List<AudioVisual> audioVisuals = new List<AudioVisual>();
            string consulta = "SELECT * FROM Material WHERE materialType = 'AudioVisual'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
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
                }
            }
            return audioVisuals;
        }
        public static Material getMaterialDataBase(int materialId)
        {

            Material material = null;
            if (getBookDataBase(materialId) != null)
            {
                material = getBookDataBase(materialId);

            }
            else if (getAudioVisualDataBase(materialId) != null)
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
        public static Reservation getReservationDataBase(int data)
        {
            Reservation reservation = null;
            string consulta = "SELECT * FROM Reservation";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        if (int.Parse(lector["userId"].ToString()) == data || int.Parse(lector["reservationId"].ToString()) == data)
                        {
                            reservation = new Reservation();
                            reservation.Id = int.Parse(lector["reservationId"].ToString());
                            reservation.User = getUserDataBase(int.Parse(lector["userId"].ToString()));
                            reservation.Material = getMaterialDataBase(int.Parse(lector["materialId"].ToString()));
                            reservation.RequestDate = DateTime.Parse(lector["requestDate"].ToString());
                            reservation.ExpirationDate = DateTime.Parse(lector["expirationDate"].ToString());
                            reservation.Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), lector["reservationStatus"].ToString());
                            break;
                        }
                    }
                }
            }
            return reservation;
        }
        public static List<Reservation> getReservationsDataBase()
        {
            List<Reservation> reservations = new List<Reservation>();
            string consulta = "SELECT * FROM Reservation";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {

                        Reservation reservation = new Reservation();
                        reservation.Id = int.Parse(lector["reservationId"].ToString());
                        reservation.User = getUserDataBase(int.Parse(lector["userId"].ToString()));
                        reservation.Material = getMaterialDataBase(int.Parse(lector["materialId"].ToString()));
                        reservation.RequestDate = DateTime.Parse(lector["requestDate"].ToString());
                        reservation.ExpirationDate = DateTime.Parse(lector["expirationDate"].ToString());
                        reservation.Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), lector["reservationStatus"].ToString());
                        reservations.Add(reservation);
                    }
                }
            }
            return reservations;
        }
        public static List<Reservation> getReservationsUserDataBase(int data)
        {
            List<Reservation> reservations = new List<Reservation>();
            string consulta = "SELECT * FROM Reservation";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        if (int.Parse(lector["userId"].ToString()) == data)
                        {
                            
                            Reservation reservation = new Reservation();
                            reservation.Id = int.Parse(lector["reservationId"].ToString());
                            reservation.User = getUserDataBase(int.Parse(lector["userId"].ToString()));
                            reservation.Material = getMaterialDataBase(int.Parse(lector["materialId"].ToString()));
                            reservation.RequestDate = DateTime.Parse(lector["requestDate"].ToString());
                            reservation.ExpirationDate = DateTime.Parse(lector["expirationDate"].ToString());
                            reservation.Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), lector["reservationStatus"].ToString());
                            reservations.Add(reservation);
                        }
                    }
                }
            }
            return reservations;
        }
        public static Loan getLoantaBase(int reservationId)
        {
            Loan loan = null;
            string consulta = "SELECT * FROM Loan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
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
                }
            }
            return loan;
        }
        public static List<Loan> getLoansDataBase()
        {
            List<Loan> loans = new List<Loan>();
            string consulta = "SELECT * FROM Loan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Loan loan = new Loan();
                        loan.Id = int.Parse(lector["loanId"].ToString());
                        loan.Reservation = getReservationDataBase(int.Parse(lector["reservationId"].ToString()));
                        loan.User = getUserDataBase(int.Parse(lector["librarianId"].ToString()));
                        loan.StartDate = DateTime.Parse(lector["startDate"].ToString());
                        loan.DueDate = DateTime.Parse(lector["endDate"].ToString());
                        loan.ReturnDate = lector["returnDate"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(lector["returnDate"].ToString());
                        loan.Status = (LoanStatus)Enum.Parse(typeof(LoanStatus), lector["loanStatus"].ToString());
                        loans.Add(loan);
                    }
                }
            }
            return loans;
        }
        
        public static List<Loan> getLoansUserDataBase(List<Reservation> reservations)
        {
            List<Loan> loans = new List<Loan>();
            List<Loan> allLoans = getLoansDataBase();
            string consulta = "SELECT * FROM Loan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    foreach (Reservation reservation in reservations)
                    {
                        foreach (Loan loan in allLoans)
                        {
                            if (reservation.Id == loan.Reservation.Id)
                            {
                                loans.Add(loan);
                            }
                        }
                    }

                }
            }
            return loans;
        }
    }
}
