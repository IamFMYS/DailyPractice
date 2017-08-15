using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AsyncIO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now.Date.AddDays(179).Date);
            Console.ReadKey();
        }
        public static async void Do()
        {
            using (FileStream fs = new FileStream("", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite, 4096, FileOptions.Asynchronous))
            {
                byte[] buffer = new byte[2048];
                await fs.ReadAsync(buffer, 0, 2048);
            }
        }
    }
}
