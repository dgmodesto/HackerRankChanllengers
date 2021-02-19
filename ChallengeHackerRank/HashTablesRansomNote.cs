using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class HashTablesRansomNote
    {
        /*
            - Harold is a kidnapper who wrote a ransom note, but now he is worried it will be traced back to him through his handwriting. 
            - He found a magazine and wants to know if he can cut out whole words from it and use them to create an untraceable replica of his ransom note. 
            - -The words in his note are case-sensitive and he must use only whole words available in the magazine. 
            - He cannot use substrings or concatenation to create the words he needs.
            - Given the words in the magazine and the words in the ransom note, print Yes if he can replicate his ransom note exactly using whole words from the magazine; otherwise, print No.
            - For example, the note is "Attack at dawn". The magazine contains only "attack at dawn". 
            - The magazine has all the right words, but there's a case mismatch. The answer is No.
         
         */
        public static void Initial(string [] args)
        {
            string[] mn = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');
            string[] note = Console.ReadLine().Split(' ');

            CheckMagazine(magazine, note);
        }

        private static void CheckMagazine(string[] magazine, string[] note)
        {
            Array.Sort(magazine);
            Array.Sort(note);

            var mglength = magazine.Length;
            var noteLenght = note.Length;
            var counter = 0;
            var match = 0;
            while(counter < mglength && match < noteLenght)
            {
                if (note[match] == magazine[counter]) match++;
                counter++;
            }

            if (match == noteLenght)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
