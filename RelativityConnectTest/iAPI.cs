using kCura.Relativity.ImportAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativityConnectTest
{
    public class iAPI
    {
        public iAPI()
        { }

        public bool Login(string username, string password, string relativityWebAPIUrl)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    ImportAPI iapi = new ImportAPI(relativityWebAPIUrl);
                }
                else
                {
                    ImportAPI iapi = new ImportAPI(username, password, relativityWebAPIUrl);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
