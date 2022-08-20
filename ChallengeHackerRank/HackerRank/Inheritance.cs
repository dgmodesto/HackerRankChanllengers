using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class Inheritance
    {

        public static void Initial(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }

    public class Person
    {
        private string firstName;
        private string lastName;
        private int id;

        public Person(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName);
            Console.WriteLine("ID: " + id.ToString());
        }

        public int Calculate()
        {

            return 0;
        }
    }
    public class Student : Person
    {
        private int[] scores;
        public Student(string firstName, string lastName, int id, int[] scores)
            : base(firstName, lastName, id)
        {
            this.scores = scores;
        }

        public string Calculate()
        {
            var average = scores.ToList().Sum() / scores.Length;
            var grade = "";
            if (90 <= average && average <= 100)
                grade = "O";
            else if (80 <= average && average < 90)
                grade = "E";
            else if (70 <= average && average < 80)
                grade = "A";
            else if (55 <= average && average < 70)
                grade = "P";
            else if (40 <= average && average < 55)
                grade = "D";
            else
                grade = "T";



            return grade;
        }
    }
}
