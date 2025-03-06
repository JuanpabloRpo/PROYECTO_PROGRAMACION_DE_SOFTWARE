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
                        User user = LogIn.NewLogIn();
                        if (user!=null)
                        {
                            if (user.TypeUser != TypeUser.LIBRARIAN)
                            {
                                LibrarianMenu LibrarianMenu = new LibrarianMenu();
                            }
                            else if (user.TypeUser == TypeUser.ADMINISTRATOR)
                            {
                                AdministratorMenu AdministratorMenu = new AdministratorMenu();
                            }
                            else
                            {
                                UserMenu UserMenu = new UserMenu();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Debes registrarte");
                        }
                        break;

                    case 2:
                        DataBase.Insert(SignUp.CreateUser());
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
