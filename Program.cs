using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectGit
{
    internal class Program
    {


        static string scans_problematic_words(string str, List<string> problrm_words)
        {


            // מילון של מילים בעיתיות 
            List<string> problem_words = new List<string> { "Warrior", "Nahva", "Bomb", "Missile", "Secret" };

            // קטע קלט של דוגמה שעליו אנחנו נעבוד 
            string input = "The warrior awaits final orders. Bomb is ready near the old Nahva checkpoint. " +
                "Transmission of the secret codes will follow at midnight sharp. Delete this after reading. " +
                "No mistakes. Next phase depends on timing. Watch the skies for signal. Prepare all units. " +
                "Loyalty is proven now.";
      
            // קטע קוד שממיר את הסטרינג ל List של מילים שכל מילה היא ערך בפני עצמו ב List
            List<string> input_string = new List<string>();
            string word = "";
            for (int i = 0; i < input.Length ; i++)
            {
                if (input[i] != ' ')
                {
                word += input[i];
                }
                else
                {
                    input_string.Add(word);
                    word = "";
                }
            }

            foreach (string item in input_string)
            {
                Console.WriteLine(item + " ");
            }

            return word;
        }


        static void Main(string[] args)
        {


        }
    }
}
