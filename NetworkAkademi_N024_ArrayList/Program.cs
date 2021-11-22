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
            Console.ReadLine();
            #endregion
        }
    }
}
