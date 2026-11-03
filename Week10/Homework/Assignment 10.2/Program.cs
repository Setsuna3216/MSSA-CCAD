using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            List<int> numbers = new List<int>
            {
                2, -1, 3, -3, 10, -200
            };
            var result =
                from n in numbers
                where n > 0
                select n;
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }

            //Q2
            Employee emp1 = new Employee
            {
                Name = "Alice",
                Age = 25,
                Salary = 6000
            };
            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(new Employee
            {
                Name = "John",
                Age = 25,
                Salary = 3000
            });

            var filteredEmployees =
                from e in employees
                where e.Age < 30 && e.Salary > 5000
                select e;

            foreach (Employee e in filteredEmployees)
            {
                Console.WriteLine($"Name: {e.Name}, Age: {e.Age}, Salary: {e.Salary}");
            }

            //Q3
            List<string> cities = new List<string>
            {
                "ROME",
                "LONDON",
                "NAIROBI",
                "CALIFORNIA",
                "ZURICH",
                "NEW DELHI",
                "AMSTERDAM",
                "ABU DHABI",
                "PARIS"
            };

            Console.Write("Enter starting character: ");
            string start = Console.ReadLine() ?? "";
            Console.Write("Enter ending character: ");
            string end = Console.ReadLine() ?? "";

            var filteredCities =
                from city in cities
                where city.StartsWith(start) && city.EndsWith(end)
                select city;

            foreach (string city in filteredCities)
            {
                Console.WriteLine($"The city starting with {start} and ending with {end} is: {city}");
            }

            //Q4
            List<int> numbersQ4 = new List<int>
            {
                55, 200, 740, 76, 230, 482, 95
            };
            var filteredNumbers =
                from n in numbersQ4
                where n > 80
                select n;

            Console.WriteLine("The numbers greater than 80 are:");
            foreach (int n in filteredNumbers)
            {
                Console.WriteLine(n);
            }

            //Q5
            char[] letters = { 'c', 'f', 'j' };
            char target = 'd';
            char answer = FindNextLetter(letters, target);
            Console.WriteLine(answer);

        }
        static char FindNextLetter(char[] letters, char target)
        {
            
            foreach (char letter in letters)
            {
                if (letter > target)
                {
                    return letter;
                }
            }
            return letters[0];
            

        }
    }
}
