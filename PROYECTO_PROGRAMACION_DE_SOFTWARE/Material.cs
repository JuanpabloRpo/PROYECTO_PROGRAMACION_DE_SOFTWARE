using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal abstract class Material
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublication { get; set; }
        public MaterialStatus Status { get; set; }
        public MaterialCondition Condition { get; set; }
        public MaterialType Type { get; set; }

        public Material(string id, string title, string author, int yearPublication, MaterialStatus status, MaterialCondition condition , MaterialType type)
        {
            Id = id;
            Title = title;
            Author = author;
            YearPublication = yearPublication;
            status = new MaterialStatus();
            condition = new MaterialCondition();
            type = new MaterialType();
        }

        protected Material(string id, string title, string author, int yearPublication, MaterialStatus status)
        {
            Id = id;
            Title = title;
            Author = author;
            YearPublication = yearPublication;
            Status = status;
        }
    }
}
