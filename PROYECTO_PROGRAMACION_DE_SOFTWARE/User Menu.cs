using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class UserMenu
    {
        public UserMenu() 
        {
            Validaciones validar = new Validaciones(); 
            Console.WriteLine("Bienvenido al sistema de prestamos de la universidad CMD");
            Console.WriteLine("Digite 1 para consultar el material disponible:\n" +
                "Digite 2 para Reservar material\n" +
                "Digite 3 para ver el estado de algun prestamo\n" +
                "Digite 4 para renovar un prestamo\n");
            int opcion = int.Parse(validar.eleccionAValidarSinSobrepasar(1,Console.ReadLine(),4));
            switch (opcion)
            {

                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;

            }

        }
    }
}
