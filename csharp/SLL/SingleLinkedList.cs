using System;

namespace SLL
{
    public class SingleLinkedList
    {
        public Node head;
        public int size = 0;

        public SingleLinkedList()
        {
            Node head = null;
        }  
        
        public void addNode(int val)
        {
            Node newNode = new Node(val);
            newNode.displayNode();

            if (this.head == null)
            {
                this.head = newNode;
            }
            else 
            {
                Node current = this.head;
                current.displayNode();
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
                this.size++;
            } 
        }
    }
}
