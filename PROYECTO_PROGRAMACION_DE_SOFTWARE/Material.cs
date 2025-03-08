using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal abstract class Material
    {
        private string Id { get; set; }
        private string Title { get; set; }
        private string Author { get; set; }
        private int YearPublication { get; set; }
        private MaterialStatus Status { get; set; }
        private MaterialCondition Condition { get; set; }
        private MaterialType Type { get; set; }

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
