using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment
{
    public class Sort
    {
        public static void BubbleSort<T>(List<T> collection, Func<T, T, bool> comparison)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = 0; j < collection.Count - 1 - i; j++)
                {
                    if (comparison(collection[j], collection[j + 1]))
                    {
                        T temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                    }
                }
            }

        }
    }
}
