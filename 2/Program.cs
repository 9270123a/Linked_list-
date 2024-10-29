using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> list = new List<int>() { 1,2,3,4,5};
            var res = list.Select(x => new Number()
            {
                Value = x
            }).ToList();

            Number number = res[0]; 
            Console.WriteLine(number.Value);

            //LinkList<int> list = new LinkList<int>();
            //LinkList<int> list2 = new LinkList<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
                
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);

            //LinkList<int> result = list.where(x=>x%2==0);



            Console.ReadKey();

            ////for(int i=0;i<list.Count;i++)
            ////{
            ////    Console.WriteLine(list[i]);
            ////}

            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.ReadKey();

            //LinkList list2 = new LinkList();
            //list2.Add("A");
            //list2.Add("e");

            //list.Removerange(0, 4);

            //foreach (Node node in list)
            //{
            //    Console.WriteLine(node.data);
            //}



            //Console.WriteLine(list);



            //Console.ReadKey();
        }
    }
}
