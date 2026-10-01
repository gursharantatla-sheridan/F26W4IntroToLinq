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




            List<string> colors = new List<string>();
            colors.Add("bLuE");
            colors.Add("ruST");
            colors.Add("grEEn");
            colors.Add("ReD");
            colors.Add("WhiTe");

            var startsWithR = from c in colors
                              let uppercaseColors = c.ToUpper()
                              where uppercaseColors.StartsWith("R")
                              orderby uppercaseColors
                              select uppercaseColors;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            colors.Add("grAy");
            colors.Add("RuBy");

            // deferred execution
            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n\n\n");




            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", "Green", 5000),
                new Employee("Anne", "Indigo", 4000),
                new Employee("Mark", "Indigo", 5500),
                new Employee("Alice", "Brown", 7000),
                new Employee("John", "Indigo", 3000),
                new Employee("Lucy", "White", 6000),
                new Employee("James", "Indigo", 4500)
            };

            foreach (var emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");




            var between4k6k = from e in employees
                              where e.Salary >= 4000 && e.Salary <= 6000
                              select e;

            foreach (var emp in between4k6k)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");




            var sortedByLastName = from e in employees
                                   orderby e.LastName, e.FirstName
                                   select e;

            foreach (var emp in sortedByLastName)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");



            var lastnames = from e in employees
                            select e.LastName;

            foreach (var emp in lastnames.Distinct())
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");



            var empFullName = from e in employees
                              select new { e.FirstName, e.LastName };

            foreach (var emp in empFullName)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");
        }
    }
}
