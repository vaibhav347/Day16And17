using System;

namespace Day16And17Prime1to1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.prime();
        }

        void prime()
        {
            int  num = 1;
            // Console.WriteLine("Enter Input between 1 to 1000");
            //num = int.Parse(Console.ReadLine());
            while (num <= 1000)
            {
                int flag = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine("Prime Number : " + num);
                num++;
            }

        }
    }
}
    


