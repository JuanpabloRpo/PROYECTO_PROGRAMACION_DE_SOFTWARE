using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            User user = new User();
            while (lector.Read())
            {
                if (lector["userName"].ToString().Equals(UserName))
                {
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
                }
            }
            connection.Close();
            return user;

        }
    }
}
