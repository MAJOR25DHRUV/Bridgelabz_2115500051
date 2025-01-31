using System;
using System.ComponentModel;
class Employee{
   public string Name{get; set;}
   public int Id{get; set;}
   public double Salary{get; set;}
   public Employee(string name, int id, double salary){
       Name = name;
       Id = id;
       Salary = salary;
   }
   public void Display(){
       Console.WriteLine(string.Format("Name: {0}",Name));
       Console.WriteLine(string.Format("Id: {0}",Id));
       Console.WriteLine(string.Format("Salary: {0}",Salary.ToString("C", CultureInfo.CurrentCulture)));
   }
}
class Program{
   public static void Main(string[] args){
       Console.WriteLine("Enter Employee Name: ");
       string name= Console.ReadLine();
       Console.WriteLine("Enter Employee Id: ");
       int id = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter Employee Salary: ");
       double salary = Convert.ToDouble(Console.ReadLine());
       Employee emp1 = new Employee(name,id,salary);
       emp1.Display();
   }
}
