using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_tree
{
    class Snake
    {
        public Node head;

        public Snake()
        {
            head = null;
        }
        public void addNext(int id, string name)
        {
            if (head == null)
            {
                head = new Node(id, name);
            }
            else
            {
                head.addNext(id, name);
            }
        }
        public void Print()
        {
            if (head != null)
            {
                head.print();
            }
        }
        

        
    }
}
