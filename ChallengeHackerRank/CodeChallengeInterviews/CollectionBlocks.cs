using System.Collections.Generic;
using System;
using System.Linq;

namespace ChallengeHackerRank.CodeChallengeInterviews
{
    public static class CollectionBlocks
    {
        private static void ValidateBlockInWords(string blocks, List<string> words)
        {
            var blockArr = blocks.Split(' ');
            foreach (var word in words)
            {
                int sizeWord = word.Length;
                int[] validateLetters = new int[sizeWord];
                var memo = new HashSet<string>();


                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];

                    foreach (var block in blockArr)
                    {
                        if (block.Contains(letter) && !memo.Contains(block))
                        {
                            validateLetters[i] = 1;
                            memo.Add(block);
                            break;
                        }
                    }
                }

                if (Enumerable.Sum(validateLetters) == sizeWord)
                {
                    Console.Write($"{word} -> True ");
                }
                else
                {
                    Console.Write($"{word} -> False ");
                }
            }

        }

        public static void Initial(string[] args)
        {
            /*
                 You are given a collection of ABC blocks (maybe like the ones you had when you were a kid).
                 There are twenty blocks with two letters on each block.
                 A complete alphabet is guaranteed amongst all sides of the blocks.
                 The sample collection of blocks:
                 (B O) (X K) (D Q) (C P) (N A) (G T) (R E) (T G) (Q D) (F S) (J W) (H U) (V I) (A N) (O B) (E R) (F S) (L Y) (P C) (Z M) (L Z)
                 Expected Results: 
                    A -> True 
                    BARK -> True 
                    SQUAD -> True 
                    CONFUSE -> True 
                    LYRIC -> True 
                    BOOK -> False 
                    TREAT -> False 
                    COMMON -> False
            */

            var blocks = "BO XK DQ CP NA GT RE TG QD FS JW HU VI AN OB ER FS LY PC ZM LZ";
            /*
            TREAT -> False
            B | O
            X | K
            B | O
                - 
            ...

            Bark -> TRUE === B | O , E| R , R | E, X | K
            Bark -> can you arrange the blocks in a way that spell "B-A-R-K" using 1 character per block
            print $word -> TRue/False
             A -> True BARK -> True SQUAD -> True CONFUSE -> True LYRIC -> True BOOK -> False TREAT -> False COMMON -> False

            */

            var words = new List<string>() {
            "A", "BARK", "BOOK", "TREAT", "COMMON",
            "SQUAD", "CONFUSE", "LYRIC"
            };
          
            ValidateBlockInWords(blocks, words);
        }

    }
}
