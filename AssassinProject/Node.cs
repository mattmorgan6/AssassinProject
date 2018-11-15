using System;
using System.Collections.Generic;
using System.Text;

namespace AssassinProject
{
    class Node
    {
        public string name;
        public Node next;

        public Node(string name)
        {
            this.name = name;
        }

        public Node(string name, Node next) : this(name)
        {
            this.next = next;
        }




    }
}
