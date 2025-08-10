namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Range<int> intRange = new Range<int>(10, 20);
            Console.WriteLine(intRange.IsInRange(15)); 
            Console.WriteLine(intRange.IsInRange(25)); 
            Console.WriteLine(intRange.Length());      

            Range<double> doubleRange = new Range<double>(1.5, 4.5);
            Console.WriteLine(doubleRange.IsInRange(3.2)); 
            Console.WriteLine(doubleRange.Length());
        }
    }
}
