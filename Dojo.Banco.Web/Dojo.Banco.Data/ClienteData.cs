using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dojo.Banco.Model;
using System.Collections;

namespace Dojo.Banco.Data
{
    public class ClienteData
    {
        public IEnumerable<Cliente> GetAll()
        {
            try
            {
                return from c in Enumerable.Range(1, 10)
                       select new Cliente
                       {
                           Id = c,
                           Nome = "Nome" + c,
                           CPF = "123",
                           Idade = 25 + c,
                           Sobrenome = "Moreira",
                           RG = "147"
                       };
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
