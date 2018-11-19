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
            setUp.Guid();


            
                                                                /*TODO:
                                                                 *  winner determined
                                                                 *  graveyard
                                                                 *  ignore capitalization?
                                                                 *  *  */

            Console.WriteLine("\n\ndone.");
            Console.ReadLine();
        }
    }
}
