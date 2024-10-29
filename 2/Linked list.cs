using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2
{


    internal class LinkList<T> : IEnumerable, IEnumerator
    {
        Node<T> _node = null;
        private int _count=0;
        private int _index = -1;

        // 存取所引子
        public T this[int i]
        {
            get
            {
                Node<T> node = _node;
                for (int j = 0; j < i; j++)
                {
                    if (node.next != null)
                    {
                        node = node.next;
                    }
                }
                return node.data;
            }
            set
            {
                Node<T> node = _node;
                while (_index < i-1)
                {

                    node = node.next;
                    _index++;
                   
                }
                node.data = value;
            }
        }

        public void Add(T n)
        {
            if (_node == null)
            {
                _node = new Node<T>(n);
            }
            else
            {
                Node<T> node = findLastNode();
                node.next = new Node<T>(n);
            }
            _count++;
        }

        public int Count { get { return _count; } }

        // Tuple => 可以一次回傳兩個結果
        public (Node<T>, Node<T>) FindPrevNode(T data)
        {

            Node<T> fiNode = _node;
            if (_node.data.Equals(data))
            {
                return (null, fiNode);
            }
            while (!fiNode.next.data.Equals(data))
            {


                fiNode = fiNode.next;
                if (fiNode.next == null)
                {
                    return (fiNode, null);
                    break;
                }

            }

            return (fiNode, fiNode.next);
        }


        public void Remove(T data)
        {
            var nodes = FindPrevNode(data);

            Node<T> prevNode = nodes.Item1; // prev
            Node<T> node = nodes.Item2; // now
            if (node == null)
            {
                Console.WriteLine("找步道");
            }
            else if (_node.data.Equals(data)) // if target node  == first node
            {
                _node = node.next;
            }
            else
            {
                prevNode.next = node.next;
            }




        }

        public void Insert(int index, T data)
        {
            Node<T> c = _node;
            while (index - 1 != 0)
            {
                c = c.next;
                index--;
            }
            Node<T> e = c.next;
            c.next = new Node<T>(data);
            c.next.next = e;


        }

        public void Addrange(LinkList<T> AddNode)
        {
            Node<T> e = findLastNode();
            Node<T> f = AddNode._node;
            e.next = f;

        }

        public void RemRange(LinkList<T> RemNode)
        {
            Node<T> n = RemNode._node;


            while (n != null)
            {

                Remove(n.data);
                n = n.next;
            }

        }
        private Node<T> findLastNode()
        {
            Node<T> b = _node;
            while (b.next != null)
            {
                b = b.next;
            }
            return b;
        }

        public void RemoveAt(int count)
        {
            Node<T> node = _node;
            while (count > 0)
            {
                node = node.next;
                count--;

            }
            Remove(node.data);

        }
        public void Removerange(int first, int last)
        {
            Node<T> node = _node;
            int a = first;
            for (int i = first; i < last; i++)
            {
                RemoveAt(a);


            }
        }




        public IEnumerator GetEnumerator()
        {
            Reset();
            return (IEnumerator)this;
        }


        //#region IEnumerator
        ////設定列舉值至它的初始位置，這是在集合中第一個元素之前。
        public void Reset()
        {
            _index = -1;
        }

        //取得集合中目前的項目。
        public object Current
        {
            get { return this[_index]; }
        }

        ////將列舉值往前推至下集合中的下一個項目
        public bool MoveNext()
        {
            _index++;
            return _index < Count;
        }


        public LinkList<T> where(Func< T , bool> func)
        {
            LinkList<T> l = new LinkList<T>();
            Node<T> node = _node;
            while(node.next!= null){
                if (func.Invoke(node.data)) {
                    l.Add(node.data);
                }
                node = node.next;
            }
            return l;

        }

       
    }
    


}

