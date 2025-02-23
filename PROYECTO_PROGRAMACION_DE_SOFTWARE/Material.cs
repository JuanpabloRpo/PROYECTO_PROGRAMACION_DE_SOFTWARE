using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Material
    {
        private string _tipoMaterial; //bibliotecario o audiovisual
        private string _autor; 
        private string _editorial;
        private string _codigo;
        private string _ubicacion; // ubicacion en la biblioteca
        private string _titulo;
        private string _disponible;
        private string _estado; // estado en el cual se encuentra el material

        public Material()
        {
        }

        public Material(string tipoMaterial, string autor, string editorial, string codigo, string ubicacion, string titulo, string disponible, string estado)
        {
            _tipoMaterial = tipoMaterial; 
            _autor = autor;
            _editorial = editorial;
            _codigo = codigo;
            _ubicacion = ubicacion;
            _titulo = titulo;
            _disponible = disponible;
            _estado = estado;
            
        }

        public string TipoMaterial { get => _tipoMaterial; set => _tipoMaterial = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public string Editorial { get => _editorial; set => _editorial = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Disponible { get => _disponible; set => _disponible = value; }
        public string Estado { get => _estado; set => _estado = value; }
    }
}
