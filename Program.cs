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


  
            static List<string> problem_words = new List<string> { "Warrior", "Nahva", "Bomb", "Missile", "Secret" };


            

            static List<string> from_string_to_list(string input)
            {

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
            return input_string;
            }


            static int scanner_text(List<string> input_to_scan)
            {

                int count = 0;
                foreach (string item in input_to_scan)
                {
                    for (int i = 0; i < problem_words.Count; i++) { 
                        if (item == problem_words[i])
                        {
                            count ++;
                        }
                    }

                }

                return count;
            }


            static string finish_commit(int count, string first_input)
            {
                string comment = "";
                if (count < 1)
                 {
                comment = $"its legal text \n {first_input}";
                    }
                if(count >1 && count <= 5)
                {
                    comment = $"warning \n {first_input} \n the count of bad words {count}";
                //Console.WriteLine($"warning \n {first_input} \n the count of bad words {count}");
                }
                else if(count >5 && count <= 11)
                {
                    comment = $"warning danderaous \n {first_input} \n the count of bad words {count}";
                    //Console.WriteLine($"warning danderaous \n {first_input} \n the count of bad words {count}");
                }
                else if(count >11 )
                {
                    comment = $"ultra alert warning danderaous \n {first_input}\n  the count of bad words{count}";
                    //Console.WriteLine($"ultra alert warning danderaous \n {first_input}\n  the count of bad words{count}");
                }
                
                return comment;
            }

        static string scans_problematic_words(string str, List<string> problrm_words)
        {
            // לעת עתה על מנת להימנע משגיאות
            return string.Empty;
        }


        static void Main(string[] args)


        {
            string input = "The warrior awaits final orders. Bomb is ready near the old Nahva checkpoint. " +
                "Transmission of the secret codes will follow at midnight sharp. Delete this after reading. " +
                "No mistakes. Next phase depends on timing. Watch the skies for signal. Prepare all units. " +
                "Loyalty is proven now.";

            List<string> text_to_check = from_string_to_list(input);
            int count = scanner_text(text_to_check);

            string comment = finish_commit(count, input);

            Console.WriteLine(comment);

        }
    }
}
