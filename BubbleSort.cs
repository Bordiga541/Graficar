using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BubbleSort
    {
        public int[] Bubble_sort(int[] vec)
        {
            int temp;
            bool mar;
            for (var i = 0; i < vec.Length - 1; i++)
            {
                mar = false;
                for (var j = 0; j < vec.Length - 1; j++)
                {
                    if (vec[j] > vec[j + 1])
                    {
                        temp = vec[j];
                        vec[j] = vec[j + 1];
                        vec[j + 1] = temp;
                        mar = true;
                    }
                }
                if (mar == false)
                {
                    return vec;
                    
                }
            }
            return vec;
        }

    }
}
