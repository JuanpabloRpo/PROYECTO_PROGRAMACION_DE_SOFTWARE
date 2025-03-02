using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Validaciones
    {
        public Validaciones()
        {
        }

        // Devuelve true si es un entero positivo
        public Boolean isInt(string dato)
        {

            try
            {

                // verificamos si no contiene letras
                double newDato = double.Parse(dato);

                if (dato.Contains("."))
                {
                    return false;
                }
                // verificamos que no sea negativo
                if (newDato < 0)
                {
                    return false;
                }

                // verificamos que sea entero
                if ((newDato > (int)newDato) && (newDato < (int)newDato + 1))
                {
                    return false;
                }

                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        // Devuelve true si es un numero real positivo
        public Boolean isDouble(string dato)
        {

            try
            {

                // verificamos si no contiene letras
                double newDato = Double.Parse(dato);

                // verdadero o falso
                return newDato > -1;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        // Devuelve un false si contiene caracteres especiales
        public Boolean withOutSpecialCharacter(string cadena)
        {

            int ascii;

            foreach (char carater in cadena.ToCharArray())
            {
                ascii = carater;
                if (((ascii > 0) && (ascii < 48)) || ((ascii > 57) && (ascii < 65)) || ((ascii > 90) && (ascii < 97)) || (ascii > 122))
                {
                    return false;
                }
            }
            return true;
        }

        // Devuelve un false si contiene caracteres especiales y numeros
        public Boolean withOutSpecialCharacterAndNumbers(string cadena)
        {

            int ascii;

            foreach (char carater in cadena.ToCharArray())
            {
                ascii = carater;
                if (((ascii > 0) && (ascii < 65)) || ((ascii > 90) && (ascii < 97)) || (ascii > 122))
                {
                    return false;
                }
            }

            return true;
        }

        // Devuelve un false si contiene caracteres especiales y numeros, pero permite los espacios
        public Boolean forFullName(string cadena)
        {

            int ascii;

            foreach (char carater in cadena.ToCharArray())
            {
                ascii = carater;

                if (((ascii > 0) && (ascii < 32)) || ((ascii > 32) && (ascii < 65)) || ((ascii > 90) && (ascii < 97)) || ((ascii > 122)))
                {
                    return false;
                }
            }

            return true;
        }

        // Menu para seleccionar la validacion adecuada y retorna el valor esperado
        public string eleccionAValidar(int opcion, string cadena)
        {
            Boolean IsTrue;

            switch (opcion)
            {
                case 1:
                    // Verificamos que si o si sea un numero entero
                    IsTrue = isInt(cadena);
                    while (!IsTrue)
                    {
                        Console.WriteLine(cadena + " No es un entero positivo, Digite nuevamente: ");
                        cadena = Console.ReadLine();
                        IsTrue = isInt(cadena);

                    }
                    return cadena;
                case 2:

                    IsTrue = isDouble(cadena);
                    while (!IsTrue)
                    {
                        Console.WriteLine(cadena + " No es un numero real positivo, Digite nuevamente: ");
                        cadena = Console.ReadLine();
                        IsTrue = isDouble(cadena);

                    }
                    return cadena;
                case 3:
                    IsTrue = withOutSpecialCharacter(cadena);
                    while (!IsTrue)
                    {
                        Console.WriteLine(cadena + " Contiene caracteres especiales, Digite nuevamente: ");
                        cadena = Console.ReadLine();
                        IsTrue = withOutSpecialCharacter(cadena);
                    }
                    return cadena;
                case 4:
                    IsTrue = withOutSpecialCharacterAndNumbers(cadena);
                    while (!IsTrue)
                    {
                        Console.WriteLine(cadena + " Contiene caracteres especiales ó numeros, Digite nuevamente: ");
                        cadena = Console.ReadLine();
                        IsTrue = withOutSpecialCharacterAndNumbers(cadena);
                    }

                    return cadena;
                case 5:
                    IsTrue = forFullName(cadena);

                    while (!IsTrue)
                    {
                        Console.WriteLine(cadena + " Contiene caracteres especiales ó numeros, Digite nuevamente: ");
                        cadena = Console.ReadLine();
                        IsTrue = forFullName(cadena);
                    }

                    return cadena;



                case 7:
                    cadena = eleccionAValidar(1, cadena);

                    while (cadena.Length > 10)
                    {
                        Console.WriteLine("El numero telefonico: " + cadena + " tiene demasiados digitos, ingreselo nuevamente: ");
                        cadena = eleccionAValidar(1, Console.ReadLine());
                    }
                    return cadena;

                default:
                    Console.WriteLine("Mijo caso incorrecto utilice bien las cosas, digite el caso manual nuevamente: ");
                    Console.WriteLine("Ya sabe que tiene que corregir la opcion del metodo no hay una opcion " + opcion + " mire bien como utilizar el metodo :)");
                    int opcionNueva = int.Parse(eleccionAValidar(1, Console.ReadLine()));
                    cadena = eleccionAValidar(opcionNueva, cadena);
                    break;
            }
            return cadena;
        }

        // Metodo para verificar un dato y aparte que no se pase de un limite
        public string eleccionAValidarSinSobrepasar(int opcion, string cadena, double noSobrepasar)
        {
            double IsTrue;
            IsTrue = double.Parse(eleccionAValidar(opcion, cadena));

            while (IsTrue > noSobrepasar)
            {
                if (opcion == 2)
                {
                    Console.WriteLine("El dato no debe sobre pasar el numero " + noSobrepasar);
                }
                else
                {
                    int noSobrepasarEntero = (int)noSobrepasar;
                    Console.WriteLine("El dato no debe sobre pasar el numero " + noSobrepasarEntero);
                }

                Console.WriteLine("ingrese el dato nuevamente: ");
                cadena = Console.ReadLine();
                IsTrue = double.Parse(eleccionAValidar(opcion, cadena));
            }

            if (opcion == 1)
            {
                return ((int)IsTrue).ToString();
            }
            else
            {
                return IsTrue.ToString();
            }
        }

    }
}
