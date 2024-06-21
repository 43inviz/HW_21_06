using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19_06_2024
{
    internal class Program
    {

        
        static void Main(string[] args)
        {

            //FrenchTranslate strings = new FrenchTranslate();
            //strings.AddTranslate();
            //strings.AddTranslate();
            //strings.AddTranslate();

            string word1 = "student";

            List<string> translateList1 = new List<string>(2);
            translateList1.Add("etudiant");
            translateList1.Add("eleve");

            FrenchTranslate translate1 = new FrenchTranslate(translateList1);

            ///////////////////////
            

            string word2 = "teacher";

            List<string> translateList2 = new List<string>(2);
            translateList2.Add("professeur");
            translateList2.Add("maitre");

            FrenchTranslate translate2 = new FrenchTranslate(translateList2);


            Dictionary<string,FrenchTranslate> newDict = new Dictionary<string,FrenchTranslate>();
            newDict.Add(word1, translate1);
            newDict.Add(word2, translate2);
            ////Proverka
            EnglishDictionary englishDict = new EnglishDictionary(newDict);

            try
            {
                Console.WriteLine("Start dictionary: ");
                englishDict.ShowAllDictionary();

                //Console.WriteLine("\nAdd new pair");
                //englishDict.AddNewWordPair();


                //Console.WriteLine("Remove pair: ");
                //englishDict.RemoveWordPair();  

                //Console.WriteLine("remove translate");
                //englishDict.removeTransFromDict();

                //Console.WriteLine("Change main word: ");
                //englishDict.ChangeMainWord();

                //Console.WriteLine("Change translate: ");
                //englishDict.changeTranslateInDict();

                Console.WriteLine("Search all translates");
                englishDict.ShowSearchPair();




                Console.WriteLine("\nResult");
                englishDict.ShowAllDictionary();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            


            
            
           





            Console.ReadLine();
        }
    }
}
