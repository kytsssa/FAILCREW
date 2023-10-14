using System;
using System.Collections.Generic;
using System.IO;

namespace hangman
{
    public class Word
    {
        private static readonly List<string> WordList = new List<string>();

        /* We can add new words to WordList below.
         * Each time the player starts a new game,
         * a random word is taken from WordList.
         * Take one word when the game starts.
         */
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

        /*
         * Static constructor for loading all
         * the words into the static List<string> 
         * WordList.
         */

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
