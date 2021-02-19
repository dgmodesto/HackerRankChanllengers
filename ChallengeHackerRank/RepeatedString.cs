using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class RepeatedString
    {
        /*
        - There is a string, s, of lowercase English letters that is rpeated infinitely many times.
        - Given an integer, n, find and print the number of letter a's in the first n letters of the infinite string.
        - Example
            - s = 'abcac'
            - n = 10
            - The substring we consider is abcacabcac, the first 10 characters of the infinite string.
            - There are 4 ocurrences of a in the substring.
         
         */

        public static void Initial(string [] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = RepeatedStrings(s, n);

            Console.WriteLine(result);
        }

        /*
        numOfS calcula quantas vezes a string s apareceu como uma string completa, até o enésimo caractere na string infinita. 

        rest representa o número de caracteres restantes após descobrir o número de s. 
        
        Por exemplo, digamos que temos uma string s "abcd" e n é igual a 10. 
        
        A string infinita será algo como "abcdabcdabcd ...". 
        
        Então, podemos quebrar essa string infinita em substrings como esta até o 10º caractere, abcd / abcd / ab. 

        Neste caso, temos 2 conjuntos completos de se um s parcial que contém apenas 2 caracteres. 
        
        numOfS nos dá 2,5, mas long é um tipo de número inteiro, então o resultado se torna 2 e 0,5 desaparece. 

        O valor 2,5 significa que temos 2 conjuntos completos de se 0,5, metade de s. 
    
        Como ab não é um s completo, precisamos descobrir como pegar aquele 0,5 que descartamos acima. 

        Agora, o resto conta o que resta, restos. 10% 4 é 2. 
            
        Finalmente, esses resultados serão passados ​​para um Contador, que literalmente conta o número de As na string, dependendo do algoritmo. 
         
         */
        private static long RepeatedStrings(string s, long n)
        {
            long count = 0, count1 = 0;
            long numOfs = (n / s.Length);
            long rest = (n % s.Length);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                    count++;
            }

            for (int i = 0; i < rest; i++)
            {
                if (s[i] == 'a')
                    count1++;
            }

            count = count * numOfs  + count;

            return count;
        }
    }
}
