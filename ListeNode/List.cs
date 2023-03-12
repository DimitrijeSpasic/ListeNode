using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeNode
{
    internal class List : Node
    {
        public Node head;
        public List()
        {
            head = null;
        }
        public Node tail;
        public void Add(int el)
        {
            Node newNode = new Node();
            newNode.el = el;
            newNode.next = null;
            newNode.prev = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node();
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next; 
                }
                temp.next = newNode;
                newNode.prev = temp;
            }
        }
        private int count;
        public int Count { get { return CountFunkcija(); } }

        public int CountFunkcija()
        {
            Node temp = new Node();
            temp = this.head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public override string ToString()
        {
            string str = "";
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    str = str + " " + Convert.ToString(temp.el);
                    temp = temp.next;
                }
                Console.WriteLine();
            }

            return str;
        }
        public void RemoveAt(int index)
        {
            if (Count == 0)
            {
                Console.WriteLine("Prazna lista");
            }
            else if (index == Count - 1)
            {
                Node pretpos = head;
                while (pretpos.next.next != null)
                {
                    pretpos = pretpos.next;
                }
                pretpos.next = null;
            }
            else if (index < Count - 1)
            {
                Node temp = new Node();
                temp = head;
                while (index > 0)
                {
                    temp = temp.next;
                    index--;

                }
                if (temp.next == null)
                {
                    tail = temp.prev;
                }   
                Node temp2 = temp.next;
                temp.el = temp2.el;
                temp.next = temp2.next;
                temp2 = null;
            }
        }
    }
    
}

