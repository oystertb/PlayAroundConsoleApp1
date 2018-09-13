using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAroundConsoleApp1
{
    public class Node
    {
        private Node next;
        private int data;

        public int Data { get => data; set => data = value; }
        public Node Next { get => next; set => next = value; }
    }
}
