using System;
using System.Data.SqlClient;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class DataBase
    {
        public static SqlConnection connection = new SqlConnection("Server=DESKTOP-UTRTB3P; Database = EjercicioProgramacion; Trusted_Connection=True;");
        public static void Insert(User user)
        {
            connection.Open();
            string consulta = $"INSERT INTO NormalUser(id,nameUser,paternalName,mothersName,age,arrears,email,userName,Userpassword,TypeUser) VALUES ({user.Id},'{user.Name}','{user.ApellidoPaterno}','{user.ApellidoMaterno}',{user.Edad},{user.Arrears},'{user.Email}','{user.UserName}','{user.Password}','{user.TypeUser.ToString()}' )";

            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("Registro creado");
            connection.Close();
        }

        public static void Delet(int id)
        {
            connection.Open();
            string consulta = $"delete from Empleado where id={id}";
            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.ExecuteNonQuery();
            Console.WriteLine("Registro eliminado");
            connection.Close();
        }

        public static bool Search(string UserName, string password) 
        {
            connection.Open();
            string consulta = "select userName,Userpassword from NormalUser";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                if (lector["userName"].ToString().Equals(UserName) && lector["Userpassword"].ToString().Equals(password))
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        public static bool Search(int id)
        {
            connection.Open();
            string consulta = "select id from NormalUser";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                if (lector["id"].ToString().Equals(id.ToString()))
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        public static bool Search(string UserName)
        {
            connection.Open();
            string consulta = "select userName from NormalUser";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                if (lector["userName"].ToString().Equals(UserName))
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        public static bool Search(string email, int none)
        {
            connection.Open();
            string consulta = "select email from NormalUser";
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                if (lector["email"].ToString().Equals(email))
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        public static void Update(int id)
        {

        }

    }
}
