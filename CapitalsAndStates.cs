namespace Informatic
{
    internal class CapitalsAndStates
    {
        internal static void WriteSomeStrings()
        {
            Console.WriteLine("Enter state.");
            var state = Console.ReadLine();
            Console.WriteLine("Enter capital of this state.");
            var capital = Console.ReadLine();

            Console.WriteLine($"By string interpolation: Столица государства {state} - город {capital}.");

            var answer = String.Format("Столица государства {0} - город {1}.",state,capital);
            Console.WriteLine("By String.Format: " + answer);
        }

    }
}
