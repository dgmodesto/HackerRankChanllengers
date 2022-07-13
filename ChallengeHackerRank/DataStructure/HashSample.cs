using System;
using System.Collections.Generic;

namespace ChallengeHackerRank.DataStructure
{
  public static class HashSample
    {
        class Employee {
            public Employee(int id, string name, string department)
            {
                Id = id;
                Name = name;
                Department = department;
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }

        static List<int> FindMissingElements(int[] first, int [] second) {
            List<int> missingElements = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();

            foreach(int item in second) {
                secondArrayItems.Add(item);
            }

            foreach(int item in first){
                if(!secondArrayItems.Contains(item)){
                    missingElements.Add(item);
                }
            }

            return missingElements;
        }

        static void DisplayFreqOfEachElement(int [] arr) {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach(int item in arr) {

                if (!dic.ContainsKey(item)) {
                    dic.Add(item, 1);
                } else {
                    dic[item] += 1;
                }
            }

            foreach(KeyValuePair<int, int> item in dic) {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static void Initial(string [] args)
        {
            Employee employee = new Employee(3827, "Douglas", "technology");            
            Employee employee1 = new Employee(9415, "Bobby", "Marketing");            
            Employee employee2 = new Employee(2519, "Sally", "Sales");            

            Dictionary<int, Employee> employeeById = new Dictionary<int, Employee>();
            employeeById.Add(employee.Id, employee);
            employeeById.Add(employee1.Id, employee1);
            employeeById.Add(employee2.Id, employee2);

            Employee e;
            if(employeeById.TryGetValue(9415, out e)) {
                Console.WriteLine(e.Name + " : " + e.Department);
            }

            HashSet<string> productCode = new HashSet<string>();

            productCode.Add("123ABC");
            productCode.Add("DEF456");
            productCode.Add("GHI789");

            productCode.Contains("987ASDF");
            productCode.Contains("GHI789");

            Console.WriteLine("****************************");

            FindMissingElements(new int [] {1, 2, 3, 4}, new int [] {2, 4}).ForEach(Console.Write);
            Console.WriteLine();
            FindMissingElements(new int [] {3,2,8,4,5,}, new int [] { 5,7,3,0,2}).ForEach(Console.Write);


            Console.WriteLine("****************************");
            DisplayFreqOfEachElement(new int [] {1, 2, 3, 4, 1, 1, 2});
            Console.WriteLine();
            DisplayFreqOfEachElement(new int [] { 5,7,3,0,2, 5, 7, 7, 1, 2, 6, 7});



        }
    }
}