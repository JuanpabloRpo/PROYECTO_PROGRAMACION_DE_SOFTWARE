using System;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class SignUp
    {
        public static User CreateUser() 
        {
            string lineas = "--------------------------------------------------";
            Validaciones validar = new Validaciones();

            TypeUser typeUser = SelectUserType();

            Console.WriteLine(lineas);
            Console.WriteLine($"-------------------- Registro De {typeUser.ToString()} --------------------");
            Console.WriteLine(lineas+"\n");
            Console.WriteLine("Ingrese su ID: ");
            int id = int.Parse(validar.eleccionAValidar(1,Console.ReadLine()));
            while (DataBase.Search(id))
            {
                Console.WriteLine("El ID ya se encuentra en la base de datos digite un id diferente");
                id = int.Parse(validar.eleccionAValidar(1, Console.ReadLine()));
            }

            Console.WriteLine(lineas + "\n");
            Console.WriteLine("Ingrese su nombre: ");
            string name = validar.eleccionAValidar(5, Console.ReadLine());


            Console.WriteLine(lineas + "\n");
            Console.WriteLine("Ingrese su primer apellido: ");
            string paternalName = validar.eleccionAValidar(5, Console.ReadLine());


            Console.WriteLine(lineas + "\n");
            Console.WriteLine("Ingrese su segundo apellido: ");
            string mothersName  = validar.eleccionAValidar(5, Console.ReadLine());


            Console.WriteLine(lineas + "\n");
            Console.WriteLine("Ingrese su edad: ");
            int age = int.Parse(validar.eleccionAValidarSinSobrepasar(1, Console.ReadLine(),80));


            Console.WriteLine(lineas + "\n");
            Console.WriteLine("Ingrese su email: ");
            string email = Console.ReadLine();
            while (DataBase.SearchEmail(email))
            {
                Console.WriteLine("El email ya se encuentra en la base de datos digite un email diferente");
                email = Console.ReadLine();
            }


            Console.WriteLine(lineas + "\n");
            Console.WriteLine("Ingrese su nombre de usuario: ");
            string userName = validar.eleccionAValidar(3, Console.ReadLine());
            while (DataBase.Search(userName))
            {
                Console.WriteLine("El nombre de usuario ya se encuentra en la base de datos digite un nuevo nombre de usuario diferente");
                userName = validar.eleccionAValidar(3, Console.ReadLine());
            }


            Console.WriteLine(lineas + "\n");
            Console.WriteLine("Ingrese su password: ");
            string Userpassword = Console.ReadLine();

            User user = new User(id,name,paternalName,mothersName,age,email,userName,Userpassword,0, typeUser);

            return user;
        }

        public static TypeUser SelectUserType()
        {
            Validaciones validar = new Validaciones();
            
            while (true)
            {
                Console.WriteLine("\n--------------------------------------------------");
                Console.WriteLine("Digite 1 si es estudiante\n" +
                    "Digite 2 si es un maestro\n" +
                    "Digite 3 si es un empleado\n");
                int opcion = int.Parse(validar.eleccionAValidarSinSobrepasar(1, Console.ReadLine(), 3));
                switch (opcion)
                {
                    case 1:
                        return TypeUser.STUDENT;
                        
                        break;
                    case 2:

                        Console.WriteLine("Digite el codigo de verificacion de maestro: ");
                        if (Console.ReadLine().Equals("159357"))
                        {
                            return TypeUser.TEACHER;
                            
                        }
                        else
                        {
                            Console.WriteLine("Codigo incorrecto");
                        }

                        break;
                    case 3:

                        Console.WriteLine("Digite el codigo de verificacion de empleado: ");
                        if (Console.ReadLine().Equals("159357"))
                        {
                            return TypeUser.EMPLOYEE;
                            
                        }
                        else
                        {
                            Console.WriteLine("Codigo incorrecto");
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            }
            

        }
        
    }
}
