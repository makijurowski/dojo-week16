using System;

namespace SLL
{
    public class Node
    {
        public int val;
        public Node next;

        public Node(int num)
        {
            val = num;
            next = null;
        }

        public void displayNode()
        {
            System.Console.WriteLine("Node val: " + val);
        }  
    }
}
