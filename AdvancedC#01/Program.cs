using System.ComponentModel.Design;

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

            //Point P1 = new Point(10, 200);
            //Point P2 = new Point(100, 20);

            //Console.WriteLine( $"{P1}");
            //Console.WriteLine( $"{P2}");
            //Console.WriteLine( "---------------------");

            //Helper<Point>.swap(ref P1, ref P2);
            //Console.WriteLine($"{P1}");
            //Console.WriteLine($"{P2}");



            #endregion

            #region Linear Search Example 
            //int[] Numbers = { 5, 8, 9, 1, 3, 4, 6, 2 };
            //int result = Helper<int>.LinearSearch(Numbers, 4);
            //Console.WriteLine( result);
            #endregion

            #region Equal & Get HashCode unsafe way
            //Employee E1 = new Employee(10, "Martin", 1000);
            //Employee E2 = new Employee(20, "Martin", 1000);

            //if (E1==E2)
            //    Console.WriteLine( "equles");
            //else
            //    Console.WriteLine( "Not Equale");
            ////by dufalt Compare With References 

            //Console.WriteLine("Not ====================");

            //if (E1.Equals(E2)) // compare values with objects
            //    Console.WriteLine( "equles");
            //else
            //    Console.WriteLine( "Not Equale");

            //Console.WriteLine($"E1 : {E1.GetHashCode()}");
            //Console.WriteLine($"E2 : {E2.GetHashCode()}");



            #endregion

            #region Is & AS Operatoer Safe way

            //1-is operator 
            //Return True => object is Empolyee
            //Return False => object is not an employee

            //Emp => pattern matching


            #endregion

            #region  IEquatable
            Employee[] emps =
            {
                new Employee (10,"re",4000),
                new Employee (20,"rw",5000),
                new Employee (30,"rq",6000),
                new Employee (40,"rs",7000),
            };

            Employee E1 = new Employee(30, "rq", 6000);
            int result = Helper<Employee>.LinearSearch(emps, E1);
            Console.WriteLine( result);
            #endregion
        }
    }
}
