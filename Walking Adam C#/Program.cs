using System;

namespace AdamSteps {
    class Evaluate
    {
        public int Calc(string testcase)
        {
            int number_of_u = 0;
            for (int i = 0; i < testcase.Length; i++)
            {
                if (testcase[i] == 'U')
                {
                    number_of_u++;
                }
                else
                {
                    return number_of_u;
                }
            }
            return number_of_u;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number_of_testcases;
            string testcase;
            number_of_testcases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number_of_testcases; i++)
            {
                testcase = Console.ReadLine();
                Evaluate Walk = new Evaluate();
                int answer = Walk.Calc(testcase);
                Console.WriteLine(answer);
            }
        }
    }
}