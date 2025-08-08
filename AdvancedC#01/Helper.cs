using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_01
{
    //genaric class contain all genaric methods 
    // i must declare the data type at the main 
    public static class Helper<T>
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
        public static void swap (ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;

        }
        #endregion
    }
}
