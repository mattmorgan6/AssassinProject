using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AssassinProject
{
    class SetUp
    {

        StudentList studentList;
        StudentList graveYard;
        string winDir = System.Environment.GetEnvironmentVariable("windir");

        public void Drive()
        {
            studentList = new StudentList();
            graveYard = new StudentList();

            List<String> originalNames = ReadInNames();     //calls method to read in names from text file and randomize

            for (int i = 0; i < originalNames.Count; i++)
            {
                studentList.Add(originalNames[i]);          //adds the names from file to the linked list
            } 
        }


        public void Gui()
        {
            string response = "";
            do
            {
                Console.WriteLine("\nfind (assignment), add, kill, or print?");    //will repeat this statement until q is typed in
                response = Console.ReadLine();

                if (response.Equals("add"))
                {
                    Console.WriteLine("Enter the person's name");
                    String name = Console.ReadLine();
                    string retA = studentList.Add(name);
                    if(retA.Equals("success"))
                    {
                        Console.WriteLine(name + " has been added to the ring. \n");
                    }
                    else
                    {
                        Console.WriteLine("That person is already in the list");
                    }
                }
                else if (response.Equals("kill"))
                {
                    Console.WriteLine("Enter the victim's name");
                    String name = Console.ReadLine();
                    string ret = studentList.Remove(name);
                    if(ret.Equals("notIncluded"))
                    {
                        Console.WriteLine("The person killed is not found in the game");
                        Console.WriteLine(name + " has been eliminated. \n");
                    }
                    else
                    {
                        graveYard.Add(ret);
                    }
                }
                else if (response.Equals("print"))
                {
                    Console.WriteLine("\n\nAlive: {0} \nDead: {1}\n", studentList.ToString(), graveYard.ToString());
                }
                else if (response.Equals("contains"))
                {
                    Console.WriteLine("Enter the victim's name");
                    String name = Console.ReadLine();
                    Console.WriteLine(studentList.Contains(name));
                }
                else if (response.Equals("find"))
                {
                    Console.WriteLine("Enter the victim's name");
                    String name = Console.ReadLine();
                    Console.WriteLine("{0} is {1}'s assignment", studentList.GetAssignment(name), name);
                }


            } while (!response.Equals("q"));
        }




        public List<String> ReadInNames()
        {
            List<String> originalNames = new List<string>();

            StreamReader reader = new StreamReader("C:\\Users\\mattm\\Desktop\\NamesA.txt");
            try
            {
                do
                {
                    //Console.WriteLine(reader.ReadLine());       //takes in one name per line
                    String s = reader.ReadLine();               //adds each line to a list and ranomizes the list
                    if (!s.Equals(""))
                    {
                        originalNames.Add(s);
                    }

                }
                while (reader.Peek() != -1);
            }

            catch
            {
                Console.WriteLine("File is empty");
            }

            finally
            {
                reader.Close();
            }


            originalNames = Shuffle(originalNames);         //shuffles the order of names

            return originalNames;
        }





        private static Random rng = new Random();

        public static List<String> Shuffle(List<String> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                String value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }

    }
}
