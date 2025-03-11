using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal struct MaterialType
    {
        public string type { get; }

        public MaterialType(string materialType)
        {
            this.type = materialType;
        }
        public static MaterialType Mathematics => new MaterialType("Mathematics");
        public static MaterialType Medicine => new MaterialType("Medicine");
        public static MaterialType Engineering => new MaterialType("Engineering");
        public static MaterialType Law => new MaterialType("Law");
        public static MaterialType Sociology => new MaterialType("Sociology");
        public static MaterialType Education => new MaterialType("Education");
        public static MaterialType BusinessAndEconomics => new MaterialType("BusinessAndEconomics");
        public static MaterialType History => new MaterialType("History");
        public static MaterialType FromString(string materialType)
        {
            switch (materialType)
            {
                case "Mathematics": return Mathematics;
                case "Medicine": return Medicine;
                case "Engineering": return Engineering;
                case "Law": return Law;
                case "Sociology": return Sociology;
                case "Education": return Education;
                case "BusinessAndEconomics": return BusinessAndEconomics;
                case "History": return History;
                default: throw new ArgumentException("Tipo de material no válido: " + materialType);
            }
        }
    }

}
