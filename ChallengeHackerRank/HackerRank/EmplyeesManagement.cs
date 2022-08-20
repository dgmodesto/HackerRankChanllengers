using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class EmplyeesManagement
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            var dic = new Dictionary<string, int>();
            var companies = employees.Select(x => x.Company).Distinct().OrderBy(x => x).ToList();

            for(int i =0; i < companies.Count(); i++)
            {
                var averageAge = (int)Math.Round(employees.Where(e => e.Company == companies[i]).Select(e => e.Age).Average());
                dic.Add(companies[i], averageAge);
            }

            return dic;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var dic = new Dictionary<string, int>();
            var companies = employees.Select(x => x.Company).Distinct().ToList();

            for (int i = 0; i < companies.Count(); i++)
            {
                var averageAge = (int)employees.Where(e => e.Company == companies[i]).Select(e => e.Age).Count();
                dic.Add(companies[i], averageAge);
            }

            return dic;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var dic = new Dictionary<string, Employee>();
            var companies = employees.Select(x => x.Company).Distinct().ToList();

            for (int i = 0; i < companies.Count(); i++)
            {
                var employee = employees.Where(e => e.Company == companies[i]).OrderByDescending(x => x.Age).FirstOrDefault();
                dic.Add(companies[i], employee);
            }

            return dic;
        }

        public static void Initial(string[] args)
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
