using System;
using System.Collections.Generic; // Needed for IEnumerable -- List
using System.Linq; // Needed for Linq methods.. Count
using System.Xml.Linq; // Needed ffor XML processing
using com.hr; // Needed for Employee

namespace listlinq
{
    class Task5
    {
        static void Main(string[] args)
        {
            
            
            string filename = "/Users/dave/data.xml";

            XElement empls = XElement.Load(filename);
            Console.WriteLine(empls);
            // Extract salaries from XML
            IEnumerable<decimal> Salaries =  from empl in empls.Descendants("emp")
                               select (decimal) empl.Element("Salary");
 
            foreach (decimal salary in Salaries) {
                Console.WriteLine(salary);
            }
            
            IEnumerable<Employee> employees =  from empl in empls.Descendants("emp")
                               select new Employee()
                                      {
                                          Firstname = (string)empl.Element("First"),
                                          Lastname = (string)empl.Element("Last"),
                                          Salary = (decimal)empl.Element("Salary")
                                      };
            foreach (Employee emp in employees) {
                Console.WriteLine(emp);
            }
            Console.WriteLine(employees.Count());
        }
    }
}
