using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Book : Material
    {
        private string Genre;
        private int Pages;

        public Book(string id, string title, string author, int publicationYear, MaterialStatus status, string genre, int pages)
            : base(id, title, author, publicationYear, status)
        {
            this.Genre = genre;
            this.Pages = pages;
        }
    }
}
