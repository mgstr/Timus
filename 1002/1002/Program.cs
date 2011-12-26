namespace _1002
{
    using System;
    using System.Collections.Generic;

    class Word : IComparable
    {
        public readonly string word;
        public readonly int index;

        public Word(string word, int index)
        {
            this.word = word;
            this.index = index;
        }

        /// <summary>
        /// Encode word into number and try to find the word position in the number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int Encode(string number, string word)
        {
            int matchStart = 0;
            int matchCurrent = -1;
            int wordChar = 0;

            // Before we enter in loop - make sure we have room for word in the current match
            if (matchStart + word.Length > number.Length)
                return -1;

            foreach (char ch in word)
            {
                int i = "oqzij abcdefgh kl mn prstuvwxy".IndexOf(ch) / 3;
                char digit = "0123456789"[i];
                chars[wordChar++] = digit;

                // Can we continue current match streak?
                if (number[matchCurrent + 1] == digit)
                {
                    ++matchCurrent;
                    continue;
                }

                // Match failed - try to find the next matching position
            NextLoop:
                matchStart = number.IndexOf(chars[0], matchStart + 1);
                if (matchStart == -1)
                    return -1;
                if (matchStart + word.Length > number.Length)
                    return -1;
                matchCurrent = matchStart;
                for (int index = 1; index < wordChar; ++index)
                    if (number[++matchCurrent] != chars[index])
                        goto NextLoop;
            }

            return matchStart;
        }

        private static char[] chars = new char[50];

        public int CompareTo(object obj)
        {
            int result = index.CompareTo(((Word)obj).index);
            if (result == 0)
                result = -word.Length.CompareTo(((Word)obj).word.Length);
            return result;
        }

        public override string ToString()
        {
            return word;
        }
    }

    class Engine
    {
        private const int maxNumberSize = 100;

        public Word[] words;
        public int numberLength;
        public int maxIndex = 0;
        public int minSolutionLength = int.MaxValue;
        public int[] solution = new int[maxNumberSize];
        public int[] solutions = new int[maxNumberSize];

        public void Add(Word word)
        {
            words[maxIndex++] = word;
        }

        public void Match(int offset, int level)
        {
            int wordIndex = offset2index[offset];
            if (wordIndex == -1)
                return;

            for (; wordIndex < maxIndex; ++wordIndex)
            {
                if (words[wordIndex].index < offset)
                    continue;

                if (words[wordIndex].index > offset)
                    return;

                if (wordIndex > 0 && words[wordIndex].word == words[wordIndex - 1].word)
                    return;

                // we found a word that matches start of our index
                solutions[level] = wordIndex;
                if (offset + words[wordIndex].word.Length == numberLength)
                {
                    if (minSolutionLength > level)
                    {
                        minSolutionLength = level;

                        for (int i = 0; i <= minSolutionLength; ++i)
                            solution[i] = solutions[i];
                    }
                    return;
                }

                if (minSolutionLength <= level)
                    // The shortes solution already found - don't bother to continue in this match
                    return;

                // we found only partial match - continue search in recursion
                Match(offset + words[wordIndex].word.Length, level + 1);
            }
        }

        public void IndexWords(int numberLength)
        {
            this.numberLength = numberLength;

            for (int index = 0; index < numberLength; ++index)
                offset2index[index] = -1;

            for (int indexWord = 0; indexWord < maxIndex; ++indexWord)
                if (offset2index[words[indexWord].index] == -1)
                    offset2index[words[indexWord].index] = indexWord;
        }

        /// <summary>
        /// Contain first word index for given offset in the number
        /// </summary>
        private int[] offset2index = new int[maxNumberSize];
    }

    class Program
    {
        static void Main()
        {
            var engine = new Engine();
            engine.words = new Word[50000];
            string number;
            while ((number = Console.ReadLine()) != "-1")
            {
                engine.maxIndex = 0;
                engine.minSolutionLength = int.MaxValue;
                var wordsCount = int.Parse(Console.ReadLine());
                for (int wordIndex = 1; wordIndex <= wordsCount; ++wordIndex)
                {
                    var wordAsString = Console.ReadLine();
                    var index = Word.Encode(number, wordAsString);
                    if (index != -1)
                        engine.Add(new Word(wordAsString, index));
                }
                if (engine.maxIndex > 0)
                    System.Array.Sort(engine.words, 0, engine.maxIndex);

                // The word array is ordered by offset, create an index page for fast word index switching
                engine.IndexWords(number.Length);

                engine.Match(0, 0);

                if (engine.minSolutionLength == int.MaxValue)
                    Console.WriteLine("No solution.");
                else
                {
                    Console.Write(engine.words[engine.solution[0]]);
                    for (int i = 1; i <= engine.minSolutionLength; ++i)
                    {
                        Console.Write(" ");
                        Console.Write(engine.words[engine.solution[i]].word);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
