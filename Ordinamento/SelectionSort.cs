using System;
using System.Collections.Generic;
using System.Text;

namespace Ordinamento
{
    public class SelectionSort
    {
        public static void Ordinamento(int[] array)
        {
            int x;
            int y;
            int i_min = 0;
            int temp;
            for ( x = 0; x < array.Length - 1; x++)
                i_min = x;
            for (y = x + 1; y < array.Length; y++)
            {
                if (array[y] < array[i_min])
                    i_min = y;
            }
            temp = array[i_min];
            array[i_min] = array[x];
            array[x] = temp;
        }
    }
}