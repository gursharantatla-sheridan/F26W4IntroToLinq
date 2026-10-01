namespace F26W4IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 3, 5, 6, 8, 4, 3, 1, 5, 8, 9, 6, 7, 5, 4, 2 };

            // query syntax
            var greaterThan4 = from num in myArr
                               where num > 4
                               orderby num
                               select num;

            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");


            // method syntax
            var lessThan5 = myArr.Where(num => num < 5).OrderByDescending(num => num);

            foreach (var i in lessThan5)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");
        }
    }
}
