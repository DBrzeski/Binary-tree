using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_tree
{
    class Node
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Node Next { get; set; }
        public Node(int id, string name)
        {
            Id = id;
            Name = name;
            Next = null;
        }
        public void addNext(int id, string name)
        {
            if (Next != null)
            {
                Next.addNext(id, name);
            }
            else
            {
                Next = new Node(id, name);
            }
        }
        public void print()
        {
            Console.Write(Name + "->");
            if (Next != null)
            {
                Next.print();
            }
        }
        //public void printback()
        //{
        //    Console.Write(Name + "->");
        //    if (Prev != null)
        //    {
        //        Prev.print();
        //    }
        //}
        public void getId()
        {
            Console.WriteLine(Id);
        }
        public void getName()
        {
            Console.WriteLine(Name);
        }
        public void count(int temp = 0)
        {
            if (Next == null)
            {
                Console.WriteLine(temp);
            }
            else
            {
                temp++;
                Next.count(temp);
            }
        }
        //public void remove()
        //{
        //    Node temp = this.Next;
        //    this.Next = null;

        //}
        //public Node lastNode()
        //{
        //    Node temp = new Node(0,"");
        //    while (Next != null)
        //    {
        //        temp = temp.Next;
        //    }
        //    return temp;
        //}

    }
}
