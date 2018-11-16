using System;

namespace AssassinProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Assassin");


            SetUp setUp = new SetUp();
            setUp.Drive();
            setUp.guid();


            
                                                                /*TODO:
                                                                 *  winner determined
                                                                 *  *  */

            Console.WriteLine("\n\ndone.");
            Console.ReadLine();
        }
    }
}
