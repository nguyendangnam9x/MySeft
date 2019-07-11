using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        /// <summary>
        /// Factory Method Pattern thuộc nhóm Creational Desgin Pattern
        /// Factory Method Pattern bao gồm những phần sau:
        ///    1. Super Class: Là một interface hoặc abstract class hoặc là một class thông thường
        ///    2. Sub Class: Các sub class sẽ implement các phương thức của super class theo nghiệp vụ riêng của nó
        ///    3. Factory Class: Một class để khởi tạo sub class dựa theo tham số đầu vào
        ///          Factory Method: Thường sử dụng if-else or switch-case để trả về đối tượng Factory mong muốn
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IBank tpBank = BankFactory.GetBankName(BankType.TPBANK);
            Console.WriteLine("TPB: " + tpBank.GetBankName());

            IBank vietcombank = BankFactory.GetBankName(BankType.VIETCOMBANK);
            Console.WriteLine("VCB: " + vietcombank.GetBankName());

            Console.ReadKey();
        }
    }
}
