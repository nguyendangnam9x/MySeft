using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Vietcombank : IBank
    {
        public string GetBankName()
        {
            return "Vietcombank";
        }
    }
}
