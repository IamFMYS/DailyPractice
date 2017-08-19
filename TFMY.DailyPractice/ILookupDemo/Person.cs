using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILookupDemo
{
    public class Person
    {
        public Person(int id,string name,int age,string addr)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Addr = addr;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Addr { get; set; }
    }
}
