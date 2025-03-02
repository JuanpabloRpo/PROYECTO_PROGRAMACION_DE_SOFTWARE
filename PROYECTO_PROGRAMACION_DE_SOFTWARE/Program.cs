using System;


namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Validaciones validar = new Validaciones();
            bool flagMenu = true;
            while (flagMenu)
            {
                Console.WriteLine("Digite 1 para iniciar sesion\n" +
                    "Digite 2 para registrarse\n" +
                    "Digite 3 para salir");
                int opcion = int.Parse(validar.eleccionAValidar(1,Console.ReadLine()));
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Digite su nombre de usuario:");
                        string UserName = validar.eleccionAValidar(3, Console.ReadLine());
                        Console.WriteLine("Digite su contraseña: ");
                        string PassWord = Console.ReadLine();

                        if (DataBase.Search(UserName,PassWord))
                        {
                            Console.WriteLine("Bienvenido");
                        }
                        else
                        {
                            Console.WriteLine("Debes registrarte");
                        }
                        break;
                    case 2:

                        Console.WriteLine("caso 2");
                        break;
                    case 3:
                        flagMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            }
            

        }
    }
}
