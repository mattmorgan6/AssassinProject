using System;
using System.Collections.Generic;
using System.Text;

namespace AssassinProject
{
    class StudentList
    {
        Node list;

        public StudentList(String name1)
        {
            list = new Node(name1);
        }


        public void LinkTailToHead()
        {
            Node current = list;
            while (current.next != null)    //goes to the last node
            {
                current = current.next;
            }

            current.next = list;    //links it to the front.
        }



        public void Add(string name)
        {
            Node n = new Node(name);
            list.next = n;
        }

        override
        public string ToString()
        {
            string r = "";
            if(list != null)
            {
                string head = list.name;

                Node current = list;
                r += current.name + ", ";
                current = current.next;

                while (current.next != null && !current.name.Equals(head))
                {
                    r += current.name + ", ";
                    current = current.next;
                }
                //r += current.name;    //only for if it is not rung
            }

            return r;
        }
    }
}
