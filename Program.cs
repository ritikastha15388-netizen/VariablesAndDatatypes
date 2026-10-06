namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            string userName = "Ritika Shrestha";
            int luckyNumber = 3;

            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            // ---- Task 2: constants ----

            Circle circle = new Circle();
            Console.WriteLine(Circle.PI);

            

            // ---- Task 3: data types and type conversion ----

            byte tiny = 200;
            short small = 30000;
            int wholeNumber = 42;
            long largeNumber = 9000000000L;
            float singlePrecision = 3.14f;
            double doublePrecision = 2.71828;
            decimal price = 19.99m;
            char initial = 'S';
            bool isLearning = true;
            string numberText = 42.ToString();
            double parsedNumber = double.Parse("3.14");

            Console.WriteLine($"byte   = {tiny}   ");
            Console.WriteLine($"short  = {small}     ");
            Console.WriteLine($"int    = {wholeNumber}       ");
            Console.WriteLine($"long   = {largeNumber} ");
            Console.WriteLine($"float  = {singlePrecision}     ");
            Console.WriteLine($"double = {doublePrecision} ");
            Console.WriteLine($"decimal= {price}    ");
            Console.WriteLine($"char   = {initial}         ");
            Console.WriteLine($"bool   = {isLearning}      ");
            Console.WriteLine($"string = {numberText}        ");
            Console.WriteLine($"parsed = {parsedNumber}      ");

            // ---- Task 4: arrays and Array methods ----

            int[] numbers = { 42, 7, 19, 3, 88 };
            Console.WriteLine($"Original : {string.Join(", ", numbers)}");

            Array.Sort(numbers);
            Console.WriteLine($"Sorted   : {string.Join(", ", numbers)}");

            Array.Reverse(numbers);
            Console.WriteLine($"Reversed : {string.Join(", ", numbers)}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"  [{i}] = {numbers[i]}");
            }

            Console.WriteLine($"IndexOf(19)  = {Array.IndexOf(numbers, 19)}");
            Console.WriteLine($"IndexOf(100) = {Array.IndexOf(numbers, 100)}");

            // ---- Task 5: DateTime and TimeSpan ----

            DateTime birthDate = new DateTime(2005, 12, 9);
            DateTime today = DateTime.Now;
            TimeSpan ageSpan = today - birthDate;
            int years = (int)(ageSpan.TotalDays / 365.25);

            Console.WriteLine($"Birth date : {birthDate:yyyy-MM-dd}");
            Console.WriteLine($"Today      : {today:yyyy-MM-dd}");
            Console.WriteLine($"Total days : {ageSpan.Days}");
            Console.WriteLine($"Age        : {years} years");
            Console.WriteLine($"Birth + 10 days : {birthDate.AddDays(10):yyyy-MM-dd}");

            // ---- Task 6: List<T> and Dictionary<K,V> ----

            List<string> fruits = new() { "Apple", "Mango", "Banana" };
            fruits.Add("Orange");
            fruits.Remove("Mango");

            foreach (string fruit in fruits)
            {
                Console.WriteLine($"  {fruit}");
            }

            Dictionary<int, string> byId = new()
            {
                { 1, "Apple" },
                { 2, "Mango" },
                { 3, "Banana" }
            };
            byId.Add(4, "Orange");

            foreach (KeyValuePair<int, string> entry in byId)
            {
                Console.WriteLine($"  {entry.Key} -> {entry.Value}");
            }
        }
    }
}
