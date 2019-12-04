using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            for (x=1;x<=20;x++)
            {
                for (y = 1; y<= 33; y++)
                {
                    for (z=3;z<=99;z+=3)
                    {
                        if(5 * x + 3 * y + z / 3 == 100 &&x + y + z == 100)
                        {

                            Console.WriteLine("公鸡买"+x+"母鸡买"+y+"小鸡买"+z);
                        }
                    }
                }
            }
            Console.ReadLine();
           
        }
    }
}
