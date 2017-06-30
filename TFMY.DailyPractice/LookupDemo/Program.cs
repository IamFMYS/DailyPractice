using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupDemo
{
    class Program
    {
        /* 
         * 必须调用ToLookup()方法创建 ILookup 实例
         * 实现了IEnumerable<T> 接口的类 可以使用ToLookup扩展方法
         * Lookup 的Key 对应一个值集合
         */
        static void Main(string[] args)
        {
            List<Racer> list = new List<Racer>()
            {
                new Racer(1,"Australia","name1"),
                new Racer(2,"Chinese","name2"),
                new Racer(3,"United Kingdom","name3"),
                 new Racer(4,"Australia","name4"),
                new Racer(5,"Australia","name5"),
                new Racer(6,"Chinese","name6")
            };

            ILookup<string, Racer> lookupList = list.ToLookup(x => x.Country);

            foreach (var item in lookupList["Chinese"])
            {
                Console.WriteLine(item.Id);
            }

            Console.ReadKey();
        }
    }
    public class Racer
    {
        public Racer(int id, string country, string name)
        {
            this.Id = id;
            this.Country = country;
            this.Name = name;
        }
        public int Id { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
    }
}
