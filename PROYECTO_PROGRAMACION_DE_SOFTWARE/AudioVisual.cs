using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class AudioVisual : Material
    {
        public string Format { get; set; }
        public string Duration { get; set; }

        public AudioVisual()
        {
        }

        public AudioVisual(int id, string title, string author, int yearPublication, MaterialStatus status, string format, string duration)
         : base(id, title, author, yearPublication, status)
        {
            this.Format = format;
            this.Duration = duration;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Id: {Id} \nTitle: {Title} \nAutor: {Author} \nAño de publicación: {YearPublication}\n" +
                $"Disponibilidad: {Status.ToString()} \nFormato: {Format} \nDuración: {Duration}");
        }
    }
}
