using System;

namespace AssassinProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the person killed.");
            string name = Console.ReadLine();

            Console.WriteLine(name + " hasn't been added to the ring. \n");

            SetUp setUp = new SetUp();
            setUp.Drive();

                                                                /*TODO:
                                                                 *  read in text file to make list
                                                                 *  randomize list
                                                                 *  allow kills
                                                                 *  winner determined
                                                                 *  allow removals
                                                                 *  allow adding to the list while it is rung
                                                                 *  *  */

            Console.WriteLine("\ndone.");
            Console.ReadLine();
        }
    }
}
