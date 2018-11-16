using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AssassinProject
{
    class SetUp
    {

        StudentList studentList;
        string winDir = System.Environment.GetEnvironmentVariable("windir");

        public void Drive()
        {
            studentList = new StudentList();

            studentList.Add("Harper");
            studentList.Add("Byron");
            studentList.Add("Juan");
            studentList.Add("Pablo");
            studentList.Add("Steven");

            /*List<String> originalNames = ReadInNames();

            for (int i = 0; i < originalNames.Count; i++)
            {
                studentList.Add(originalNames[i]);
            } */

            //-------------------------------------------------------------------------------
            /*studentList.LinkTailToHead();                         //for Testing purposes:

            //Console.WriteLine(studentList.GetSize());  //prints the size of the list

            Console.WriteLine("Starting List: " + studentList.ToString());
            studentList.Remove("Pablo");
            
            //Console.Write("\nremoveing Harper\n");
            //studentList.Remove("Steven");

            Console.WriteLine("\n\nThe assignment is: " + studentList.GetAssignment("Juan"));


            Console.WriteLine(studentList.ToString()); */
        }


        public void guid()
        {
            
            string response = "";
            do
            {
                Console.WriteLine("\nadd, kill, or print?");
                response = Console.ReadLine();

                if (response.Equals("add"))
                {
                    Console.WriteLine("Enter the person's name");
                    String name = Console.ReadLine();
                    studentList.Add(name);
                    Console.WriteLine(name + " has been added to the ring. \n");
                }
                else if (response.Equals("kill"))
                {
                    Console.WriteLine("Enter the victim's name");
                    String name = Console.ReadLine();
                    studentList.Remove(name);
                    Console.WriteLine(name + " has been eliminated. \n");
                }
                else if (response.Equals("print"))
                {
                    Console.WriteLine(studentList.ToString());
                }
                else if (response.Equals("contains"))
                {
                    Console.WriteLine("Enter the victim's name");
                    String name = Console.ReadLine();
                    Console.WriteLine(studentList.Contains(name));
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
                    String s = reader.ReadLine();
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
