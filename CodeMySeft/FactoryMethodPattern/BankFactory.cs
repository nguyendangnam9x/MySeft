using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class BankFactory
    {
        public BankFactory()
        {

        }

        public static IBank GetBankName(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.VIETCOMBANK:
                    {
                        return new Vietcombank();
                    }
                case BankType.TPBANK:
                    {
                        return new TPBank();
                    }
                default:
                    {
                        throw new Exception("Exception here.");
                    };
            }
        }
    }
}
