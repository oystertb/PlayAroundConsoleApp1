using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlayAroundConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int[,] twoDimArr = new int[5, 2];
            ArrayList arrList = new ArrayList();
            Hashtable ht = new Hashtable();
            HashSet<int> hs = new HashSet<int>(){ 1, 2, 3 };
            Dictionary<string, int> d = new Dictionary<string, int>()
            {
                {"tr", 0 },
                {"uk", 1 },
                {"ch", 2 }
            };
            List<double> l = new List<double>() { 1.2, 3.5, 7.8 };
            List<Product> pList = new List<Product>();
            Stack s = new Stack();
            Queue<int> q = new Queue<int>();
            LinkedList l1 = new LinkedList();

            WriteLinkedList(l1);
            //WriteArray(n);
            //WriteTwoDimArr(twoDimArr);
            //CreateArrList(arrList);
            //WriteHashTable(ht);
            //WriteClassObj();
            //WriteHashSet(hs);
            //WriteDictionary(d);
            //WriteList(pList);


            Console.ReadKey();
        }
        public static void WriteLinkedList(LinkedList lMethod)
        {
            lMethod.Print();
            lMethod.AddNode(1);
            lMethod.Print();
            lMethod.Print();
            lMethod.AddNode(7);
            lMethod.AddNode(3);
            lMethod.Print();
            lMethod.AddLastNode(99);
            lMethod.AddLastNode(8);
            lMethod.Print();
            lMethod.DeleteGivenNode(3);
            lMethod.Print();
            lMethod.DeleteGivenNode(8);
            lMethod.Print();
            lMethod.DeleteGivenNode(1);
            lMethod.Print();
            lMethod.AddAfterGivenNode(99, 77);
            lMethod.Print();
            lMethod.AddAfterGivenNode(7, 1);
            lMethod.Print();

        }
        public static void WriteList(List<Product> pL)
        {
            pL.Add(new Product("aaa", 4));
            pL.Add(new Product("bbb", 7));

            foreach(Product p in pL)
            {
                if(p.Age == 4)
                {
                    Console.WriteLine(p.Name);
                }
            }

        }

        public static void WriteDictionary(Dictionary<string,int> d1)
        {
            int number = d1["tr"];
            Console.WriteLine(number);

        }

        public static void WriteHashSet(HashSet<int> hs1)
        {
            hs1.Add(4);
            hs1.Remove(2);

            if (hs1.Contains(1))
            {
                HashSet<int> hs2 = new HashSet<int> { 4, 5 };
                hs1.UnionWith(hs2);
            }
            //hs1.Add(4);
            //hs1.Add(5);
            foreach(int i in hs1)
            {
                Console.WriteLine(i);
            }
        }

        public static void WriteClassObj()
        {
            Product p1 = new Product("Selen", 29);
            Product p2 = new Product("Chris", 28);
            Product p3 = new Product("Selin", 23);

            ArrayList proArrList = new ArrayList();
            proArrList.Add(p1);
            proArrList.Add(p2);
            proArrList.Add(p3);

            foreach(Product p in proArrList)
            {
                Console.WriteLine("{0}", p);
            }

        }

        protected static void WriteHashTable(Hashtable h1)
        {
            h1.Add(06,"Ankara");
            h1.Add(35, null); // value can be null but key can not be
            Console.WriteLine("Hashtable 06: {0}", h1[06]);
            //Console.WriteLine("Hashtable 06: {0}", h1[1]);// Didnt work. No insertion order!

        }

        public static void CreateArrList(ArrayList al)
        {
            al.Add("Selen");
            al.Add(14);
            al.Reverse();
            ArrayList al2 = new ArrayList { "Merhaba", "Ben", "Selen", 10, 17 };
            String[] strArr = new String[3];
            strArr[0] = "a";
            strArr[1] = "ab";
            strArr[2] = "gg";
            

            foreach(String s in strArr)
            {
                al.Add(s);
            }
           
            //al.RemoveAt(0);

            al.AddRange(al2);

            foreach(object item in al)
            {
                Console.WriteLine(item);
            }

        }

        static void WriteArray(int[] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i + 100;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}]: {1}", j, arr[j]);
            }

        }

        private static void WriteTwoDimArr(int[,] arrTwoDim)
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    arrTwoDim[a, b] = (a + b) * 2;
                    Console.WriteLine("Element[{0},{1}]: {2}", a, b, arrTwoDim[a, b]);
                }
            }

        }
    }
}
