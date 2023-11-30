using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd
{
    class Sort
    {
      
        public static List<int> SortList(List<int> list, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = list[leftIndex];

            while (i <= j)
            {
                while (list[i] < pivot)
                {
                    i++;
                }

                while (list[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortList(list, leftIndex, j);

            if (i < rightIndex)
                SortList(list, i, rightIndex);

            return list;
        }
    }
}
