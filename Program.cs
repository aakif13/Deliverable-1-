namespace Deliverable_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)
            {
                try
                {
                    Console.Write("Enter an integer number between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }

                catch
                {
                    Console.WriteLine("Invalid input. Please enter an integer value");
                }
            }
            
            while (true)
            {
                    Console.Write("Specify the series type: Even or Odd: ");
                    series = Console.ReadLine();

                    if (series == "Even" || series == "Odd")
                    {
                        break;
                    }
            }

            if (series == "Odd")
            {
                Console.WriteLine();
                Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            
            if (series == "Even")
            {
                Console.WriteLine();
                Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }


    }
}