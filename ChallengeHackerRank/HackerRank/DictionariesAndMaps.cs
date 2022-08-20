using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class DictionariesAndMaps
    {
        /*
         Input

3
sam 99912222
tom 11122222
harry 12299933
sam
edward
harry
         
        output

sam=99912222
Not found
harry=12299933
         
         */

        public static void Initial(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            var n = Convert.ToInt32(Console.ReadLine());

            var listPhone = new Dictionary<string, string>();
            var listName = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var contact = Console.ReadLine().ToString().Split(' ');

                if (contact[1].Length < 8)
                    continue;


                listPhone.Add(contact[0], contact[1]);
            }

            string name = "";
            while ((name = Console.ReadLine()) != null)
            {

                if (listPhone.TryGetValue(name, out string value))
                {
                    Console.WriteLine(name + "=" + value);
                }
                else
                {
                    Console.WriteLine("Not found");
                }

            }
        }
    }
}
