using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PROGRAMACION_DE_SOFTWARE
{
    internal class Manager : User, IAuthentication
    {
        public bool Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public override void UpdateData(Dictionary<string, object> NewData)
        {
            throw new NotImplementedException();
        }

        public override string ViewProfile()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string id) { }
        public void ModifyUser(string id, Dictionary<string, object> data) { }

    }
}
