using System;

namespace Binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            //snake.addNext(1, "Damian");
            //snake.addNext(2, "Zuzia");
            //snake.addNext(3, "Magda");
            //snake.addNext(4, "Paskaksl");
            //snake.addNext(5, "Patryk");
            //snake.Print();
            //snake.getId();
            Node head = new Node(1, "Damian");
            head.addNext(2, "Zuzia");
            head.addNext(3, "Kamil");
            head.getId();
            head.Next.getName();
            head.count();
            head.Next.count();
            //head.print();
            head.remove();
            head.Next.printback();
        }

    }
}
