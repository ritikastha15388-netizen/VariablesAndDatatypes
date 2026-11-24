namespace OperatorsAndControlFlow
{
    class Program
    {
        static void Main()
        {
            // Add Task 1 to Task 6 here, in this order.
            // ---- Task 1 ----
            int points = 10;
            points += 5;
            points *= 2;
            Console.WriteLine($"Final points: {points}");

            bool atLeast25 = points >= 25;
            Console.WriteLine($"At least 25 points: {atLeast25}");

            int afterPost = points++;
            Console.WriteLine($"points++ returned {afterPost}; points is now {points}");

            int afterPre = ++points;
            Console.WriteLine($"++points returned {afterPre}; points is now {points}");

            // ---- Task 2 ----
            int marks = 72;
            int attendance = 80;

            string grade;
            if (marks >= 80)
            {
                grade = "A";
            }
            else if (marks >= 65)
            {
                grade = "B";
            }
            else if (marks >= 50)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }

            bool isEligible = marks >= 50 && attendance >= 75;

            Console.WriteLine($"Marks: {marks}, Attendance: {attendance}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Pass eligible: {isEligible}");

            // ---- Task 3 ----
            int choice = 2;
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Borrow   2. Return   3. Renew");
            Console.WriteLine($"Selected choice: {choice}");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Borrow.");
                    break;
                case 2:
                    Console.WriteLine("You selected Return.");
                    break;
                case 3:
                    Console.WriteLine("You selected Renew.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            string? userName = null;
            string displayName = userName ?? "Guest";
            Console.WriteLine($"Display name: {displayName}");

            userName ??= "Guest";
            Console.WriteLine($"userName after ??=: {userName}");

            // ---- Task 4 ----
            int[] dailyAttendance = { 20, 22, 21, 24, 23 };
            int total = 0;

            Console.WriteLine("Daily attendance:");
            foreach (int present in dailyAttendance)
            {
                Console.WriteLine($"  {present}");
                total += present;
            }
            Console.WriteLine($"Total attendance: {total}");

            for (int i = 0; i < dailyAttendance.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyAttendance[i]}");
            }

            int countdown = 3;
            while (countdown >= 1)
            {
                Console.WriteLine(countdown);
                countdown--;
            }

            bool runAgain = false;
            do
            {
                Console.WriteLine("Attendance recorded");
            }
            while (runAgain);

            // ---- Task 5 ----
            int seatCount = 0;

            for (int row = 1; row <= 3; row++)
            {
                for (int seat = 1; seat <= 4; seat++)
                {
                    Console.WriteLine($"Row {row} - Seat {seat}");
                    seatCount++;
                }
            }
            Console.WriteLine($"Total seats: {seatCount}");

            Console.Write("Loop values: ");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                if (i == 8)
                {
                    break;
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // ---- Task 6 ----
            Console.Write("Enter the first integer: ");
            string firstInput = Console.ReadLine() ?? "";
            Console.Write("Enter the second integer: ");
            string secondInput = Console.ReadLine() ?? "";

            try
            {
                int first = int.Parse(firstInput);
                int second = int.Parse(secondInput);
                int result = first / second;
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: please enter whole numbers only.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Calculation complete");
            }
        }
    }
}