using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILookupDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>() {
                new Person(0,"name0",0,"addr0"),
                new Person(1,"name1",1,"addr1-1"),
                new Person(2,"name3",2,"addr1-2"),
                new Person(3,"name3",3,"addr1-3"),
                new Person(4,"name4",4,"addr4-1"),
                new Person(5,"name5",5,"addr4-2"),
                new Person(6,"name6",6,"addr4-3"),
                new Person(7,"name7",7,"addr1"),
                new Person(8,"name8",7,"addr4"),
            };
            ILookup<string,Person> lookup = persons.ToLookup(x =>{
                if (x.Addr.Contains("-")) return x.Addr.Substring(0, 5);
                else return x.Addr;
            });
            Console.Read();
        }
    }
    
}
