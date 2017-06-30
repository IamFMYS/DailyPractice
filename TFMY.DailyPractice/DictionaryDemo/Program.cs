using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //容量一般是素数 
            var employees = new Dictionary<EmployeeId, Employee>(31);
            var idTony = new EmployeeId("C3755");
            var tony = new Employee(idTony, "Tony Stewart", 379025.00m);
            employees.Add(idTony, tony);
            Console.WriteLine(tony);

            var idCarl = new EmployeeId("F3547");
            var carl = new Employee(idCarl, "Carl Edwards", 403466.00m);
            employees.Add(idCarl, carl);
            Console.WriteLine(carl);

            var idKevin = new EmployeeId("C3386");
            var kevin = new Employee(idKevin, "Kevin Harwick", 415261.00m);
            employees.Add(idKevin, kevin);
            Console.WriteLine(kevin);

            var idMatt = new EmployeeId("F3323");
            var matt = new Employee(idMatt, "Matt Kenseth", 1589390.00m);
            employees[idMatt] = matt;
            Console.WriteLine(matt);

            var idBrad = new EmployeeId("D3234");
            var brad = new Employee(idBrad, "Brad Keselowski", 322295.00m);
            employees[idBrad] = brad;
        }
    }
}
