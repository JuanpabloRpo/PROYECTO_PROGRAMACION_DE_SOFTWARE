using System;
using System.Data.SqlClient;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class DataBase
    {
        public static SqlConnection connection = new SqlConnection("Server=DESKTOP-UTRTB3P; Database = EjercicioProgramacion; Trusted_Connection=True;");

        public InsertDataBase InsertDataBase;

        

         

    }
}
