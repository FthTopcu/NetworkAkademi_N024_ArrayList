using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N024_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            //10 elamanlı (string) arraylist içindeki değerleri Z-A olacak şekilde sıralayın
            ArrayList odevList = new ArrayList();
            odevList.Add("Fatih");
            odevList.Add("Zuhal");
            odevList.Add("Mahmut");
            odevList.Add("Adem");
            odevList.Add("Gamze");
            odevList.Add("Hakan");
            odevList.Add("Furkan");
            odevList.Add("Birol");
            odevList.Add("Cem");
            odevList.Add("Yakup");
            odevList.Add("Salih");


            //tüm değerli A-Z çevir
            odevList.Sort();
            odevList.Reverse();
            foreach (var item in odevList)
            {
                Console.WriteLine(item);
            }
            int capacity = 0;
            int count = 0;

            string[] isimler = new string[10];

            ArrayList a1 = new ArrayList();

            #region Tek Deger Ekleme

            a1.Add("Erdem");
            a1.Add("Erdem");
            a1.Add("Erdem");
            a1.Add("Erdem");
            a1.Add("Erdem");
            a1.Add("Erdem");
            a1.Add("Erdem");
            a1.Add("Erdem");
            a1.Add("Erdem");
            a1.Add("Erdem");
            a1.Add(33);
            #endregion

            capacity = a1.Capacity;
            count = a1.Count;

            Console.WriteLine(capacity + " " + count);


            #endregion
            Console.WriteLine("---------");
            Console.WriteLine();
            #region birden fazla değer ekleme işlemi
            ArrayList a2 = new ArrayList();
            a2.Add("utku");
            a2.Add("merve");
            a2.Add("utkan");
            a2.Add("mervan");
            a2.Add("nerd");
            a1.AddRange(a2);

            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }

            #endregion
            #region koleksiyon içindeki değere ulaşmak
            object o1 = a1[3];
            string s1 = a1[3].ToString();
            //int i1 = (int)a1[1];
            a1[3] = "Hamza Atilla";
            #endregion

            #region dizinin mevcut elemanlarını ters olarak sıralama

            a1.Remove(33);
            a1.Reverse();
            //a-z sıralama
            a1.Sort();
            #endregion

            #region koleksiyonlar yardımıc komutları

            if (a1.Contains("muzo"))
            {
                int indexDegeri = a1.IndexOf("muzo");
                Console.WriteLine(indexDegeri);
                a1.RemoveAt(indexDegeri);
            }
            else
            {
                Console.WriteLine("böyle biri yok");
            }
            #endregion

            //bool kontrol1 = a1.Contains("utkan");
            //bool kontrol2 = a1.Contains(900);
            //Console.WriteLine(kontrol1+" "+kontrol2);

            //object[] d1 = a1.ToArray();
            //foreach (var item in d1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("**********************");
            //a1.Clear();

            //foreach (var item in a1)
            //{
            //    Console.WriteLine(item);
            //}
            //a1.Add("defne");
            Console.WriteLine(a1.Capacity);
            a1.TrimToSize();
            Console.WriteLine(a1.Capacity);
            Console.WriteLine("************");
            #region arraylist koleksiyonu içerisindeki silme
            a1.Remove(3);
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**********");
            a1.RemoveRange(2, 2);
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
