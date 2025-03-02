using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal interface IMaterialManagement
    {
        string Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        int YearPublication { get; set; }
        string Category { get; set; }
        MaterialStatus Status { get; set; }

        
    }
}
