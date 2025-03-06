using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class IMaterialManagement
    {
        public IMaterialManagement()
        {
            Console.WriteLine("Bienvenido");
            void CreateMaterial(Material material);
            void ModifyMaterial(string id, Dictionary<string, object> data);
            void DeleteMaterial(string id);
        }
    }
}
