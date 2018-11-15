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

        public void Add(string name)
        {
            Node n = new Node(name);
            list.next = n;
        }

        override
        public string ToString()
        {
            string r = "";

            Node current = list;
            while(current.next != null)
            {
                r += current.name + ", ";
                current = current.next;
            }
            r += current.name;

            return r;
        }
    }
}
