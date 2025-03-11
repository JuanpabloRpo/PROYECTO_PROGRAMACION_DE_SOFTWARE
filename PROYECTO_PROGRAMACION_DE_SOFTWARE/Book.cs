using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Book : Material
    {
        public int Pages { get; set; }

        public Book()
        {
        }

        public Book(int id, string title, string author, int publicationYear, MaterialStatus status, int pages)
            : base(id, title, author, publicationYear, status)
        {
            this.Pages = pages;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"Id: {Id} \nTitle: {Title} \nAutor: {Author} \nAño de publicación: {YearPublication}\n" +
                $"Disponibilidad: {Status.ToString()} \nCantidad de paginas: {Pages}");
        }
    }
}
