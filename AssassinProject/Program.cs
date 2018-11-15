using System;

namespace AssassinProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the person killed.");
            string name = Console.ReadLine();

            Console.WriteLine(name);

            SetUp setUp = new SetUp();
            setUp.Drive();

                                                /*TODO:
                                                 *  set up classes
                                                 *  read in text file to make list
                                                 *  randomize list
                                                 *  allow kills
                                                 *  winner determined
                                                 *  */


            Console.ReadLine();
        }
    }
}
