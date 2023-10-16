using System;
using System.Collections.Generic;
using System.IO;

namespace hangman
{
    public class Word
    {
        private static readonly List<string> WordList = new List<string>();

     
        private static Word wordPack;
        public static Word WordPack
        {
            get
            {
                if (wordPack == null)
                {
                    wordPack = new Word();
                }
                return wordPack;
            }
        }

        public string TheWord { get; private set; }

        private Word()
        {
            StreamReader sr = new StreamReader("word_list.txt");
            while (!sr.EndOfStream)
            {
                WordList.Add(sr.ReadLine());
            }
        }

        public void LoadWord()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, WordList.Count);
            TheWord = WordList[num];
        }

    }
}
