using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace projectGit
{
    internal class Program
    {
        static string decryptedText (string text)
        {
            string decryptedText = "";

            Dictionary<char, char> dictionaryEncrypte = new Dictionary<char, char>();

            dictionaryEncrypte.Add('a', 'z');
            dictionaryEncrypte.Add('b', 'y');
            dictionaryEncrypte.Add('c', 'x'); 
            dictionaryEncrypte.Add('d', 'w');
            dictionaryEncrypte.Add('e', 'v');
            dictionaryEncrypte.Add('f', 'u');
            dictionaryEncrypte.Add('g', 't');
            dictionaryEncrypte.Add('h', 's');
            dictionaryEncrypte.Add('i', 'r');
            dictionaryEncrypte.Add('j', 'q');
            dictionaryEncrypte.Add('k', 'p');
            dictionaryEncrypte.Add('l', 'o');
            dictionaryEncrypte.Add('m', 'n');
            dictionaryEncrypte.Add('n', 'm');
            dictionaryEncrypte.Add('o', 'l');
            dictionaryEncrypte.Add('p', 'k');
            dictionaryEncrypte.Add('q', 'j');
            dictionaryEncrypte.Add('r', 'i');
            dictionaryEncrypte.Add('s', 'h');
            dictionaryEncrypte.Add('t', 'g');
            dictionaryEncrypte.Add('u', 'f');
            dictionaryEncrypte.Add('v', 'e');
            dictionaryEncrypte.Add('w', 'd');
            dictionaryEncrypte.Add('x', 'c');
            dictionaryEncrypte.Add('y', 'b');
            dictionaryEncrypte.Add('z', 'a');
            dictionaryEncrypte.Add('A', 'Z');
            dictionaryEncrypte.Add('B', 'Y');
            dictionaryEncrypte.Add('C', 'X');
            dictionaryEncrypte.Add('D', 'W');
            dictionaryEncrypte.Add('E', 'V');
            dictionaryEncrypte.Add('F', 'U');
            dictionaryEncrypte.Add('G', 'T');
            dictionaryEncrypte.Add('H', 'S');
            dictionaryEncrypte.Add('I', 'R');
            dictionaryEncrypte.Add('J', 'Q');
            dictionaryEncrypte.Add('K', 'P');
            dictionaryEncrypte.Add('L', 'O');
            dictionaryEncrypte.Add('M', 'N');
            dictionaryEncrypte.Add('N', 'M');
            dictionaryEncrypte.Add('O', 'L');
            dictionaryEncrypte.Add('P', 'K');
            dictionaryEncrypte.Add('Q', 'J');
            dictionaryEncrypte.Add('R', 'I');
            dictionaryEncrypte.Add('S', 'H');
            dictionaryEncrypte.Add('T', 'G');
            dictionaryEncrypte.Add('U', 'F');
            dictionaryEncrypte.Add('V', 'E');
            dictionaryEncrypte.Add('W', 'D');
            dictionaryEncrypte.Add('X', 'C');
            dictionaryEncrypte.Add('Y', 'B');
            dictionaryEncrypte.Add('Z', 'A');
            
            for( int i = 0; i < text.Length; i++)
            {
                if (dictionaryEncrypte.ContainsKey(text[i]))
                {
                decryptedText += dictionaryEncrypte[text[i]];

                }
                else
                {

                    decryptedText += text[i];
                }

            }
            return decryptedText;
        }

        //פונקציה לבדיקת תו ומפענחת
        static string ConvertedByAccii(string text)
        {
            string str ="";
            string NewLowr = text.ToLower();
            int atbsh=Convert.ToInt32('a'+'z');
            Console.WriteLine(atbsh);
            for (int i = 0; i < NewLowr.Length; i++) {

                if (NewLowr[i]>'a'&& NewLowr[i] < 'z')
                {
                    str += ((char)(atbsh - Convert.ToInt32(NewLowr[i])));
                }
                else
                {
                    str += NewLowr[i];

                }
            }
            return str;
        }
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

   string input =ConvertedByAccii("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh. Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg. Erxglib rh mvzi. Hgzb ivzwb.");

            List<string> text_to_check = from_string_to_list(input);
            int count = scanner_text(text_to_check);

            string comment = finish_commit(count, input);

            Console.WriteLine(comment);
        }
    }
}
