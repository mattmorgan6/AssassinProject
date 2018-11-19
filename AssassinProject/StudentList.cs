using System;
using System.Collections.Generic;
using System.Text;

namespace AssassinProject
{
    class StudentList
    {
        Node list;
        int size;

        public StudentList()
        {
            size = 0;
        }

        public string GetAssignment(String nameR)
        {
            String ret = "The name you entered isn't in the game";
            Node current = list;

            //use the size
            for (int i = 0; i < size; i++)
            {
                if (current.name.Equals(nameR))
                {
                    ret = current.next.name;
                }
                current = current.next;
            }

            return ret;
        }




        public void Remove(String nameR)
        {
            if(Contains(nameR))
            {

                Node current = list;
                if (list.name.Equals(nameR))
                {
                    list = list.next;
                    size--;
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (current.next.name.Equals(nameR))
                        {
                            current.next = current.next.next;   //removes it
                            size--;
                        }

                        current = current.next;
                    }
                }

                LinkTailToHead();
            }
            else
            {
                Console.WriteLine("That person is not in the game");
            }
        }

        



        public void Randomize()     //TBD if I have time
        {
            int tempSize = size;

            Node current = list;

            Random rnd = new Random();

            for (int i = 0; i < tempSize; i++)
            {
                int place = rnd.Next(0, size - 1);  //gets the index to move to.


                current = current.next;
            }

            

        }

        public void Swap(int index1, int index2)        //TBD if i have time
        {
            Node t1 = list;

            for (int i = 0; i < index1-1; i++)  //goes to the node before the swap one
            {
                t1 = t1.next;
            }

            Node replaceFirst = t1.next;

            Node t2 = list;

            for (int i = 0; i < index2-1; i++)  //goes to the node before the swap one
            {
                t2 = t2.next;
            }

            Node replaceSecond = t2.next;
            
            


        }




        public void LinkTailToHead()
        {
            Node current = list;
            for (int i = 0; i < size-1; i++)
            {
                current = current.next;
            }

            current.next = list;    //links it to the front.
        }



        public void Add(string name)
        {
            Node n = new Node(name);

            if (list == null) {
                list = n;
            }
            else
            {
                Node current = list;
                for (int i = 0; i < size-1; i++)
                {
                    current = current.next;
                }
                current.next = n;
            }

            size++;
            LinkTailToHead();
        }

    

        override
        public string ToString()
        {
            string r = "";

            Node current = list;
            for (int i = 0; i < size-1; i++)
            {
                r += current.name;
                r += ", ";
                current = current.next;
            }
            r += current.name;

            return r;
        }

        public int GetSize()
        {
            return size;
        }

        public bool Contains(string nameR)
        {
            Boolean r = false;
            Node current = list;
            for (int i = 0; i < size; i++)
            {
                if(current.name.Equals(nameR)) {
                    r = true;
                    break;
                }
                current = current.next;
            }

            return r;
        }


    }
}
