using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class MaterialMethods : IMaterialManagement
    {
        public void SearchMaterial()
        {
            Console.WriteLine("Buscando material...");
        }
        public void CreateMaterial()
        {
            Console.WriteLine("Creando material...");
        }
        public void UpdateMaterial()
        {
            Console.WriteLine("Actualizando material...");
        }
        public void DeleteMaterial()
        {
            Console.WriteLine("Eliminando material...");
        }
        public void ViewAvaraibleMaterials()
        {
            
            Console.WriteLine("Viendo materiales disponibles...");
            foreach (Material material in GetDataBase.getMaterialsDataBase())
            {
                if (material.Status == MaterialStatus.Available)
                {
                    Console.WriteLine("-----------------------------");
                    material.MostrarInfo();
                    Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}
