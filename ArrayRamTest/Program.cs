using System;

namespace ArrayRamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                gagga[] array = new gagga[63000000];

                Console.WriteLine("fillign array");
                Random rnd = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new gagga(rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10));
                }


                Console.WriteLine("array filled with junk");
                


            }
            catch (Exception e)
            {
                Console.WriteLine("perkele en toimi. Error: "+e);
                
            }
            string text = Console.ReadLine();

        }
    }
}
