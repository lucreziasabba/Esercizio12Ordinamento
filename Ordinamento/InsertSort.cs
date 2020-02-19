using System;
using System.Collections.Generic;
using System.Text;

namespace Ordinamento
{
    public class InsertSort
    {
        public static void Ordinamento(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int a = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > a)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = a;
            }
        }
    }
}
