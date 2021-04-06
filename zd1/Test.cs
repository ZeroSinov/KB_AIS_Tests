using System;
using System.Collections.Generic;
using System.Text;

namespace zd1
{
    class Test
    {
        /// <summary>
        /// Данная функция подсчитывает количество повторений каждого числа, встреченного в заданной строке.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Dictionary<char, int> Zd1_Ansver(string input)
        {
            Dictionary<char, int> answer = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    if (!answer.ContainsKey(input[i]))
                    {
                        answer.Add(input[i], 1);
                    }
                    else
                    {
                        answer[input[i]] += 1;
                    }
                }
            }
            return answer;
        }
    }
}
