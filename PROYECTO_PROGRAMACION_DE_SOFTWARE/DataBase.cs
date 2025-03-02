using System;
using System.Data.SqlClient;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class DataBase
    {
        public static SqlConnection connection = new SqlConnection("Server=DESKTOP-UTRTB3P; Database = EjercicioProgramacion; Trusted_Connection=True;");
        public static void Insert(int id, string nombre, int edad, string sexo, string fecha)
        {
            connection.Open();
            string consulta = $"insert into Empleado (id, nombre, edad, sexo, fechaDeNacimiento) VALUES ({id}, '{nombre}', {edad}, '{sexo}', '{fecha}')";

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
            string consulta = "select * from userData";
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

        public static void Update(int id)
        {

        }

    }
}
