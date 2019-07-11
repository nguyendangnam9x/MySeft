using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        /**
         * Singleton Design Pattern
         * 1. Đảm bảo 1 class chỉ có duy nhất 1 instance - Tức là khởi tạo 1 lần mà dùng mãi
         * 2. Cung cấp toàn cầu để truy cập đến instance đó
         * Lưu ý khi làm việc với đơn luồng hoặc đa luồng
         * 
         * Sử dụng Parallel.Invoke để test trường hợp đa luồng (multiple thread). Chạy function cùng một thời điểm
         * Trường hợp đa luồng: 
         *    - Cần sử dụng lock để đảm bảo rằng trong cùng 1 thời điểm chỉ được gọi instance 1 lần
         * */
        static void Main(string[] args)
        {
            Parallel.Invoke(() => Instant1(), () => Instance2());
            Console.ReadKey();
        }

        private static void Instance2()
        {
            Singleton instance2 = Singleton.Instance;
            instance2.LogMessage("Message instance 2");
        }

        private static void Instant1()
        {
            Singleton instance1 = Singleton.Instance;
            instance1.LogMessage("Message instance 1");
        }
    }
}
