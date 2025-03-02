using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class NormalUser: User, IAuthentication
    {
        public bool Login(string usuario, string contrasena)
        {
            return false;
        }
        public void Logout() { }
        public bool ConsultarDisponibilidad(string titulo) => true;
        

        public override string ViewProfile()
        {
            throw new NotImplementedException();
        }

        public override void UpdateData(Dictionary<string, object> NewData)
        {
            throw new NotImplementedException();
        }
    }
}
