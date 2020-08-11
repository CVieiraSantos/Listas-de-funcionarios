using System;
using System.Globalization;
using System.Collections.Generic;


namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();
            

             for (int i = 1; i <= n; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();

                Console.Write("Enter the employee id that will have salary increase : ");
                int idSearch = int.Parse(Console.ReadLine());
                
                Employee employees1 = employees.Find(x => x.Id == idSearch);
                if(employees1 != null){
                Console.Write("Enter the percentage");                    
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees1.increaseSalary(porcentagem);
                }

                else{
                    Console.WriteLine("This id does not exist!");
                }

                Console.WriteLine();
                Console.WriteLine("Updated list of employees:");
                foreach(Employee obj in employees){
                    Console.WriteLine(obj);       
                }
                
                
            }
        
        }            
        
    }


         public class Employee {
         public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        
        public Employee(int id, string name, double salary){
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage){
            Salary+= Salary * percentage / 100;
        }

        public override string ToString(){
            return Id 
            + ", " 
            + Name 
            + ", " 
            + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    
}
