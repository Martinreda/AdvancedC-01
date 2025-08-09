using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_01
{
    //genaric class contain all genaric methods 
    // i must declare the data type at the main 
    public static class Helper<T> where T : IEquatable<T>
    {
        #region Swap EX 
        //public static void swap (ref int x ,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp; 

        //}
        //public static void swap (ref decimal x ,ref decimal y)
        //{
        //    decimal temp = x;
        //    x = y;
        //    y = temp; 

        //}
        //public static void swap(ref Point x, ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;

        //}
        // hna kol da tkraar m3nf3shhh f lazm ast5dm algenarics from 1 method  

        /*Genaric method
         * T => Template 
         * compiler will outo know the datatype at main
         */
        //public static void swap (ref T x, ref T y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp;

        //}
        #endregion
        #region Linear Search Example 
      
        public static int LinearSearch(T[] arr , T value)
        {
if (arr is not null && arr.Length > 0 && value is not null)
            {
                for(int i = 0; i <arr.Length; i++)
                {
                    ////== cannot me applied to T class 
                    //if (arr[i] == value)
                    if (value.Equals(arr[i]))
                        return i;
                }
            }
            return -1;
        }
        #endregion
    }
}
