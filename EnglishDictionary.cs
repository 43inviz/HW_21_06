using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19_06_2024
{
    internal class EnglishDictionary
    {
        public Dictionary<string,FrenchTranslate> MainDicionary { get; set; }

        public EnglishDictionary() {
           MainDicionary = new Dictionary<string,FrenchTranslate>();
        }

        public EnglishDictionary(Dictionary<string, FrenchTranslate> mainDicionary)
        {
            MainDicionary = mainDicionary;
        }

        public void AddNewWordPair()
        {
            string newWord,newTranslate;

            Console.Write("Enter new word: ");
            newWord = Console.ReadLine();
            


            FrenchTranslate frenchTranslate = new FrenchTranslate();
            frenchTranslate.AddTranslateInTranslations();

            addNewPair(newWord, frenchTranslate);
        }

        private void addNewPair(string engWord,FrenchTranslate translate) {
            try
            {
                MainDicionary.Add(engWord, translate);

            }
            catch (Exception ex){ 
                Console.WriteLine(ex.ToString());
            }
        }


        public void RemoveWordPair()
        {
            try
            {
                string sWord;
                Console.Write("Enter searched word: ");
                sWord = Console.ReadLine();
                removePair(sWord);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        private void removePair(string word)
        {
            if(MainDicionary.ContainsKey(word))
            {
                MainDicionary.Remove(word);

            }
            else
            {
                throw new Exception("incorect key for search");
            }
        }





        public void ShowSearchPair()
        {
            
            string sWord;
            Console.Write("Enter searched word: ");
            sWord = Console.ReadLine();
            if (MainDicionary.ContainsKey(sWord))
            {
                foreach(var el in MainDicionary)
                {
                    KeyValuePair<string, FrenchTranslate> key = el;
                    if(key.Key == sWord)
                    {
                        showPair(key);
                    }
                }

            }
            else
            {
                throw new Exception("Incorrect word");
            }
        }


        public void showPair(KeyValuePair<string,FrenchTranslate> pair)
        {
            Console.Write($"Word: {pair.Key} || Translation: ");
            foreach(var el in pair.Value)
            {
                Console.Write($" {el}");
            }
            Console.WriteLine();
        }

        public void ShowAllDictionary()
        {
            foreach(var el in MainDicionary)
            {
                showPair(el);
            }
        }

        public void addTranslateInDict() //добав перевод в массив переводов кокнкретного слова
        {
            string sWord;
            Console.Write("Enter searched word: ");
            sWord = Console.ReadLine();
            if (MainDicionary.ContainsKey(sWord))
            {
                MainDicionary[sWord].AddTranslateInTranslations();
            }
            else
            {
                throw new Exception("Incorrect word");
            }
        }

        public void changeTranslateInDict()//конкретного слова
        {
            string sWord;
            Console.Write("Enter searched word: ");
            sWord = Console.ReadLine();
            if (MainDicionary.ContainsKey(sWord))
            {
                MainDicionary[sWord].ChangeTranslate();
            }
            else
            {
                throw new Exception("Incorrect word");
            }
        }


        public void removeTransFromDict()
        {
            string sWord;
            Console.WriteLine("Enter searched word: ");
            sWord = Console.ReadLine();
            if (MainDicionary.ContainsKey(sWord))
            {
                MainDicionary[sWord].RemoveChoodenTranslate();
            }
            else { throw new Exception($"Incorrect key: {sWord}"); }
        }


        public void ChangeMainWord()
        {
            string sWord;
            Console.WriteLine("Enter searched word: ");

            sWord = Console.ReadLine();
            if (MainDicionary.ContainsKey(sWord))
            {
                string newValue;
                Console.WriteLine("Enter new word: ");
                newValue = Console.ReadLine();

                FrenchTranslate newTranslates = new FrenchTranslate(MainDicionary[sWord].Translations);
                MainDicionary.Remove(sWord);
                MainDicionary.Add(newValue, newTranslates);
                

            }
            else
            {
                throw new Exception($"Incorrect key: {sWord}");
            }
        }

    }
}
