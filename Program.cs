using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace c_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList()
            { 1, "bill", true, 4.5

            };
            var list3 = new ArrayList() { true, 4.5 };
            list.AddRange(list3);
            list.Insert(1, "mahmut");
            list.InsertRange(2, list3);
            list.RemoveAt(2);
            list.RemoveRange(0, 2);//0dan iki arasındaki indeksili elamanısil
            foreach
                (var item in list)
            {
                Console.WriteLine(item);//araya eleman ekleme filan bir soru gelcek dedi
            }
           for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            

        }
       

    }
}
