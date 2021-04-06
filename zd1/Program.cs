using System;
using System.Collections.Generic;

namespace zd1
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check_Test(1));
            Console.WriteLine(Check_Test(2));

            List<int> list = new List<int>() { 1, 2, 3 };
            Cycler cycler = new Cycler(list);
            for (int i = 0; i < 8; i++)
            {
                Console.Write(cycler.GetNext() + ",");
            }
        }
        /// <summary>
        /// Эта функция является проверосной для Zd1_Ansver
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Check_Test(int num)
        {
            string ans = "There is no check with number " + num.ToString();
            Dictionary<char, int> output;
            switch (num)
            {
                case 1:
                    ans = "input: t5qr33d56q3\noutput:\n";
                    output = Test.Zd1_Ansver("t5qr33d56q3");
                    foreach (char item in output.Keys)
                    {
                        ans += item + ":" + output[item].ToString() + "\n";
                    }
                    break;
                case 2:
                    ans = "input: ;f2*14'2444\noutput:\n";
                    output = Test.Zd1_Ansver(";f2*14'2444");
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
