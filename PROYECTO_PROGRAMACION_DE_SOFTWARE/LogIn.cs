using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class LogIn
    {
        public static User NewLogIn()
        {
            Validaciones validar = new Validaciones();
            Console.WriteLine("Digite su nombre de usuario:");
            string UserName = validar.eleccionAValidar(3, Console.ReadLine());
            Console.WriteLine("Digite su contraseña: ");
            string PassWord = Console.ReadLine();

            if (SearchDataBase.SearchUser(UserName, PassWord))
            {
                return GetDataBase.getUserDataBase(UserName);

            }
            else
            {
                return null;
            }
        }
    }
}
