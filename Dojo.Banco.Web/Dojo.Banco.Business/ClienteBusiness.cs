using Dojo.Banco.Data;
using Dojo.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Banco.Business
{
    public class ClienteBusiness
    {
        public IEnumerable<Cliente> GetAll()
        {
            try
            {
                ClienteData client = new ClienteData();
                return client.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
