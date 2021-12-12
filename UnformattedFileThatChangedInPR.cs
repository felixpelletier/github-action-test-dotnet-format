using System;

namespace FormattingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (TheProgram.FeelsLikeSayingHello())
            {
                Console.WriteLine(Constants.HELLO_WORLD);
            }
        }
    }
}