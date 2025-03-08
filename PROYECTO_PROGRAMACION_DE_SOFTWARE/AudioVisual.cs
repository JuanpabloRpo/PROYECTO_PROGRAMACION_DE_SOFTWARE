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

        public AudioVisual(string id, string title, string author, int yearPublication, MaterialStatus status, string format, string duration)
         : base(id, title, author, yearPublication, status)
        {
            this.Format = format;
            this.Duration = duration;
        }
    }
}
