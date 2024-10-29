using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {

            this.data = data;
            this.next = null;

        }
    }
}
