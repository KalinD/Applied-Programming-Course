using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_of_employees {
    class Program {
        static void Main(string[] args) {
            List<Employee> employees = CreateEmployess(int.Parse(Console.ReadLine()));
            Dictionary<string, List<double>> salaries = new Dictionary<string, List<double>>();
            foreach(Employee employee in employees){
                if(!salaries.ContainsKey(employee.Department)) {
                    salaries[employee.Department] = new List<double>();
                    salaries[employee.Department].Add(1);
                    salaries[employee.Department].Add(employee.Salary);
                    continue;
                }
                salaries[employee.Department][1] += employee.Salary;
                salaries[employee.Department][0]++;
            }
            double max = 0;
            string department = "";
            foreach(var salary in salaries){
                salaries[salary.Key][1] = salaries[salary.Key][1] / salaries[salary.Key][0];
                if(salaries[salary.Key][1] > max){
                    max = salaries[salary.Key][1];
                    department = salary.Key;
                }
            }
            Console.WriteLine($"Highest Average Salary: {department}");
            employees = employees.OrderBy(x => x.Salary).ToList();
            employees.Reverse();
            foreach (Employee employee in employees){
                if(employee.Department == department){
                    Console.WriteLine(employee.ToString());
                }
            }
        }

        static List<Employee> CreateEmployess(int n){
            List<Employee> employees = new List<Employee>();
            for(int i = 0; i < n; i++){
                List<string> input = Console.ReadLine().Split(' ').ToList();
                Employee employee = new Employee();
                employee.Name = input[0];
                employee.Salary = double.Parse(input[1]);
                employee.Rank = input[2];
                employee.Department = input[3];
                if(input.Count >= 5){
                    try{
                        employee.Age = int.Parse(input[4]);
                    }
                    catch(Exception){
                        employee.Email = input[4];
                    }
                }
                if(input.Count == 6){
                    employee.Age = int.Parse(input[5]);
                }
                employees.Add(employee);
            }
            return employees;
        }
    }
}
