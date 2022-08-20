using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class DesignerPdfViewer
    {

        /*
         https://www.hackerrank.com/challenges/designer-pdf-viewer/problem?isFullScreen=true
        */

        public static int designerPdfViewer(List<int> h, string word)
        {
            var alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int result = 0;
            int maxValue = int.MinValue;

            for(int i =0; i < word.Length; i++)
            {
                char w = word[i];
                var index = Array.IndexOf(alphabet, w.ToString());
                var value = h[index];
                maxValue = maxValue < value ? value : maxValue;
            }

            result = word.Length * maxValue;

            return result;
        }

        public static void Initial(string[] args)
        {

            List<int> h = Console
                .ReadLine()
                .TrimEnd()
                .Split(' ')
                .ToList()
                .Select(hTemp => Convert.ToInt32(hTemp)).ToList();

            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);

        }

    }
}
