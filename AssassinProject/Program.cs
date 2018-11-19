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
            setUp.Gui();

            
                                                                /*TODO:
                                                                 *  ignore capitalization?
                                                                 *  *  */

            Console.WriteLine("\n\ndone.");
            Console.ReadLine();
        }
    }
}
