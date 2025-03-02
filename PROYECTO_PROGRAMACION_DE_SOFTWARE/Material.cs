using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal abstract class Material
    {
        public Material()
        {
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublication { get; set; }
        public string Category { get; set; }
        public MaterialStatus Status { get; set; }

        public Material(string id, string title, string author, int yearPublication, string category, MaterialStatus status)
        {
            Id = id;
            Title = title;
            Author = author;
            YearPublication = yearPublication;
            Category = category;
            Status = status;
        }


    }
}
