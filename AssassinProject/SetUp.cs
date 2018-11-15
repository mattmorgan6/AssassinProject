using System;
using System.Collections.Generic;
using System.Text;

namespace AssassinProject
{
    class SetUp
    {

        public void Drive()
        {

            //file IO:  https://support.microsoft.com/en-us/help/304430/how-to-do-basic-file-i-o-in-visual-c

            StudentList studentList = new StudentList("Byron");
            studentList.Add("Nathan");


            studentList.LinkTailToHead();


            Console.WriteLine(studentList.ToString());

        }


    }
}
