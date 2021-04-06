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

        /// <summary>
        /// Эта функция является проверосной для Zd1_Ansver
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Check(int num)
        {
            string ans = "There is no check with number " + num.ToString();
            Dictionary<char, int> output;
            switch (num)
            {
                case 1:
                    ans = "input: t5qr33d56q3\noutput:\n";
                    output = Zd1_Ansver("t5qr33d56q3");
                    foreach (char item in output.Keys)
                    {
                        ans += item + ":" + output[item].ToString() + "\n";
                    }
                    break;
                case 2:
                    ans = "input: ;f2*14'2444\noutput:\n";
                    output = Zd1_Ansver(";f2*14'2444");
                    foreach (char item in output.Keys)
                    {
                        ans += item + ":" + output[item].ToString() + "\n";
                    }
                    break;
            }
            return ans;
        }
    }
}
