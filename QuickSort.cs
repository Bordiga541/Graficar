using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class QuickSort
    {

        public int[] Quick_Sort(int[] arr)
        {
            int tamaño = arr.Length;

            if (tamaño <= 1)
            {
                return arr;
            }
            int pivot = arr[0];
            List<int> izq = new List<int>();
            List<int> der = new List<int>();
            int i;
            for (i = 1; i < tamaño; i++)
            {
                if (arr[i] < pivot)
                {
                    izq.Add(arr[i]);
                }
                else
                {
                    der.Add(arr[i]);
                }
            }
            
            int[] arrayIzq = Quick_Sort(izq.ToArray());
            int[] arrayDer = Quick_Sort(der.ToArray());

            return arrayIzq.Concat(new int[] { pivot }).Concat(arrayDer).ToArray();
        }
        

        
    }
}
