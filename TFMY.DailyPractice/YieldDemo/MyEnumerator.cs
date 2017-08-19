/*
 * foreach 的实质是
 * 获取一个Enumerator 
 * 循环输出Currentitem（Enumerator.MoveNext()）
 */
using System;
using System.Collections;


namespace YieldDemo
{

    public class MyEnumeratorDemo
    {
        public static void Do1()
        {
            Person p = new Person();
            p.Id = 234;
            p.Name = "Hellow";
            p.Addr = "This is an Address";
            p.Phone = "15832163021";
            foreach (var item in p)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }


        public static void Do2()
        {
            Persons ps = new Persons();
            //等价于 foreach
            //TEMP 1
            IEnumerator personsEnumerator = ps.GetEnumerator();
            //TEMP 2
            while (personsEnumerator.MoveNext())
            {
                Console.WriteLine(personsEnumerator.Current.ToString());
            }
        }
    }


    public class Person : IEnumerable
    {

        public int Id { get; set; }


        public string Name { get; set; }


        public string Addr { get; set; }


        public string Phone { get; set; }


        private int index { get; set; }


        public Person()
        {

        }


        public Person(int id, string name, string addr, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Addr = addr;
            this.Phone = phone;
        }

        public IEnumerator GetEnumerator()
        {
            System.Reflection.PropertyInfo[] propertyInfo = typeof(Person).GetProperties();
            for (int i = 0; i < propertyInfo.Length; i++)
            {
                yield return propertyInfo[i].GetValue(this);
            }
        }

        public override string ToString()
        {
            return string.Format("Id:{0},Name:{1},Address{2},Phone:{3}", Id, Name, Addr, Phone);
        }
    }


    public class Persons
    {

        Person[] persons = new Person[4];

        public Persons()
        {
            persons[0] = new Person(1, "name1", "addr1", "phone1");
            persons[1] = new Person(2, "name2", "addr2", "phone2");
            persons[2] = new Person(3, "name3", "addr3", "phone3");
            persons[3] = new Person(4, "name4", "addr4", "phone4");
        }

        public IEnumerator GetEnumerator()
        {
            return persons.GetEnumerator();
        }
    }


}
