using System;
using System.Collections.Generic;
using System.Text;

namespace Message
{
    static public class Message {

        public static void LessThanN(int N, string mes)
        {
            mes += ' ';
            int letter = 0;
            string word = null;
            for(int i = 0; i < mes.Length; i++)
            {
                if(mes[i] == ' ')
                {
                    if (letter <= N)
                    {
                        Console.WriteLine(word);
                    }
                    letter = 0;
                    word = null;
                    continue;
                }
          
                letter++;
                word += mes[i];
            }
        }

        public static string DeleteWord(char c, string mes)
        {
            mes += ' ';
            string word = null;
            for (int i = 0; i < mes.Length; i++)
            {
                if (mes[i] == ' ')
                {
                    if (mes[i - 1] == c)
                    {
                        mes = mes.Replace(word, "");
                    }
                    word = null;
                    continue;
                }

                word += mes[i];
            }
            return mes;
        }

        public static string LongestWord(string mes)
        {
            int max = 0;
            mes += ' ';
            int letter = 0;
            string word = null;
            string answer = null;
            for (int i = 0; i < mes.Length; i++)
            {
                if (mes[i] == ' ')
                {
                    if (letter > max)
                    {
                        max = letter;
                        answer = word;
                    }
                    letter = 0;
                    word = null;
                    continue;
                }

                letter++;
                word += mes[i];
            }
            return answer;
        }

        public static StringBuilder BuildLongestWord(string mes, int n)
        {
            Console.WriteLine(n);
            StringBuilder answer = new StringBuilder(LongestWord(mes), n);
            Convert.ToString(answer);
            return answer;
        }

    }
}
