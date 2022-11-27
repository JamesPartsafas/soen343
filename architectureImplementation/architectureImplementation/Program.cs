using System;

namespace architectureImplementation
{
    class Program
    {
        // Passes in mock data to demonstrate functionality, using a sample member instance
        static void Main(string[] args)
        {
            var member = new Member();

            // Request food assistance successfully
            var successfulFoodResult = member.RequestFoodAssistance(new Space("St Catherine Street", 100), 6, 1000.00);
            Console.WriteLine(successfulFoodResult);

            // Request food assistance with incorrect data
            var failedFoodResult = member.RequestFoodAssistance(null, 6, 1000.00);
            Console.WriteLine(failedFoodResult);

            // Request translator session successfully on January 1 2023 at 12:30
            var successfulTranslationResult = member.RequestTranslatorSession(new Space("St Catherine Street", 100), "French", new DateTime(2023, 1, 1, 12, 30, 0));
            Console.WriteLine(successfulTranslationResult);

            // Request translator session with incorrect data
            var failedTranslationResult = member.RequestTranslatorSession(null, "French", new DateTime(2023, 1, 1, 12, 30, 0));
            Console.WriteLine(failedTranslationResult);
        }
    }
}
