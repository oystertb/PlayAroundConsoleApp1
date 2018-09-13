using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAroundConsoleApp1
{
    public class LinkedList
    {
        private Node head;

        public void Print()
        {
            Node cur = head;
            Console.Write("HEAD->");
            while(cur != null)
            {
                Console.Write(cur.Data + "->");
                cur = cur.Next;
            }
            Console.WriteLine("null");

        }

        public void AddNode(int n) //Adds first
        {
            Node temp = new Node();
            temp.Data = n;

            temp.Next = this.head;
            this.head = temp;
        }

        public void AddNode(Node n1) //Adds first
        {
            n1.Next = this.head;
            this.head = n1;
        }

        public void AddLastNode(int n)
        {
            Node temp = new Node();
            temp.Data = n;

            if(this.head == null)
            {
                this.head = temp;
            }
            else
            {
                Node cur = head;
                while(cur.Next != null)
                {
                    cur = cur.Next;
                }
                temp.Next = cur.Next;
                cur.Next = temp;
            }
        }

        public void AddLastNode(Node n1)
        {

        }

        public void DeleteGivenNode(int g)
        {
            Node cur = head;
            Node temp = null;

            if(temp == null && cur.Data == g)
            {
                head = cur.Next;
                return;
            }
            while (cur.Data != g)
            {
                temp = cur;
                cur = cur.Next;
            }
            temp.Next = cur.Next;
        }

        public void AddAfterGivenNode(int givenNodeData, int newNodeData)
        {
            Node cur = head;
            Node temp = new Node();
            temp.Data = newNodeData;

            while(cur.Data != givenNodeData)
            {
                cur = cur.Next;
            }

            temp.Next = cur.Next;
            cur.Next = temp;

        }

        public void Reverse()
        {

        }
    }
}
