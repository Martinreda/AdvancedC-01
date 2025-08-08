namespace AdvancedC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Genarics 
            /*
             * Feature in C# 2.0
             * Generic existed in many lanage
             * Code usable for any Datatype
             * 
             * Benefits of Generics :_
             * 1-Type saftry
             * 2-code usability 
             * 3-performance No boxing and unboxing 
             */

            //Swap => between 2 numbers
            //Swap => between 2 Decimal numbers
            //Swap => between 2 Point (X, Y) numbers

            //int a = 10, b = 20;
            //Console.WriteLine($" A : {a}");
            //Console.WriteLine($"B : {b}");
            //Console.WriteLine("=============");

            //Helper<int>.swap(ref a, ref b);
            //Console.WriteLine($" A : {a}");
            //Console.WriteLine($"B : {b}");
            //Console.WriteLine("=============");


            //decimal c = 10.10M, d = 20.20M;
            //Console.WriteLine($"c : {c}");
            //Console.WriteLine($"d : {d}");
            //Console.WriteLine("=============");

            //Helper<decimal>.swap(ref c, ref d);
            //Console.WriteLine($"c : {c}");
            //Console.WriteLine($"d : {d}");

            Point P1 = new Point(10, 200);
            Point P2 = new Point(100, 20);

            Console.WriteLine( $"{P1}");
            Console.WriteLine( $"{P2}");
            Console.WriteLine( "---------------------");

            Helper<Point>.swap(ref P1, ref P2);
            Console.WriteLine($"{P1}");
            Console.WriteLine($"{P2}");



            #endregion
        }
    }
}
