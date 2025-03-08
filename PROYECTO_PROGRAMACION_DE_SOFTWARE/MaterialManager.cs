using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    class MaterialManager
    {
        private IMaterialManagement materialMethods;

        public MaterialManager(IMaterialManagement materialMethods)
        {
            this.materialMethods = materialMethods;
        }
        public void ShowMenu()
        {
            Validaciones validar = new Validaciones();
            bool flagMenu = true;

            while (flagMenu)
            {
                Console.WriteLine("Bienvenido al gestor de préstamos.");
                Console.WriteLine(
                    "Digite 1 para buscar material\n" +
                    "Digite 2 para crear un material\n" +
                    "Digite 3 para modificar un material\n" +
                    "Digite 4 para eliminar un material\n" +
                    "Digite 5 para ver materiales disponibles\n" +
                    "Digite 6 para regresar al menu anterior\n" +
                    "Digite 7 para salir");

                int option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        materialMethods.SearchMaterial();
                        break;
                    case 2:
                        materialMethods.CreateMaterial();
                        break;
                    case 3:
                        materialMethods.UpdateMaterial();
                        break;
                    case 4:
                        materialMethods.DeleteMaterial();
                        break;
                    case 5:
                        materialMethods.ViewAvaraibleMaterials();
                        break;
                    case 6:
                        Console.WriteLine("Regresando al menu anterior...");
                        flagMenu = false;
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del sistema...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
