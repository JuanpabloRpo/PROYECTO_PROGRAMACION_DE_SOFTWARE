using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class SearchDataBase
    {
        public static SqlConnection connection = new SqlConnection("Server=DESKTOP-UTRTB3P; Database = ProgramacionDataBase; Trusted_Connection=True;");
        public static bool SearchUser(string UserName, string password)
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
        public static bool SearchEmail(string email)
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

    }
}
