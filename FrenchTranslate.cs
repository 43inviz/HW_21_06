using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19_06_2024
{
    internal class FrenchTranslate
    {
        public List<string> Translations { get; set;}

        public FrenchTranslate() { 
            Translations = new List<string>();
        }
        public FrenchTranslate(List<string> translations)
        {
            Translations = translations;
        }



        public void AddTranslateInTranslations()
        {
            string newWord;
            Console.Write("Enter new translate:  ");
            newWord = Console.ReadLine();
            addNewWord(newWord);
        }

        private void addNewWord(string word)
        {
            Translations.Add(word);
        }




        public void RemoveChoodenTranslate()
        {
            try
            {
                string remWord;
                Console.Write("Enter word for remove: ");
                remWord = Console.ReadLine();
                removeWord(remWord);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }

        private void removeWord(string word)
        {
            if (Translations.Contains(word))
            {
                Translations.Remove(word);

            }
            else
            {
                throw new Exception("Word absent in translations");
            }
        }


        public void ChangeTranslate()
        {
            try
            {
                string searchWord, newWord;
                Console.Write("Enter searched translate: ");
                searchWord = Console.ReadLine();
                Console.Write("Enter new version: ");
                newWord = Console.ReadLine();
                changeTranslate(searchWord, newWord);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

        }

        private void changeTranslate(string word,string newTranslate)
        {
            if (Translations.Contains(word))
            {
                int index  = Translations.IndexOf(word);
                Translations.Remove(word);
                Translations.Insert(index, newTranslate);
            }
            else
            {
                throw new Exception ("Word absent in transations");
            }
        }

        //public void ShowTranslate()
        //{
        //    foreach(string word in Translations)
        //    {
        //        Console.Write($"{word} ");
        //    }
        //}

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string word in Translations)
            {
                yield return word;
            }
        }


    }
}
