using System;

namespace architectureImplementation
{
    class Program
    {
        // Represents the user interface for interacting with the backend system. 
        // This class handles reading user input through a terminal window, simulating input being passed in through client-side applications
        // A sample member instance is used for this purpose.
        static void Main(string[] args)
        {
            var member = new Member();

            Console.WriteLine("Welcome to Community Outreach! Please select your preferred service.");
            Console.WriteLine("You may choose from: Food Assistance, Translator Request, or Event Volunteer.");

            Console.Write("Select service: ");
            string service = Console.ReadLine().ToLowerInvariant();

            if (service.Equals("food assistance"))
            {
                RequestFoodData(member);
            }
            else if (service.Equals("translator request"))
            {
                RequestTranslatorData(member);
            }
            else if (service.Equals("event volunteer"))
            {
                var volunteerResult = member.VolunteerForEvent();
                Console.WriteLine(volunteerResult);
            }
            else
            {
                Console.WriteLine("That service is not available. Please enter a valid service.");
            }
        }

        static void RequestFoodData(Member member)
        {
            Console.Write("Please enter the street name: ");
            string street = Console.ReadLine();

            Console.Write("Please enter the address number: ");
            int address = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of members in your family: ");
            int familySize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your total income: ");
            double totalIncome = Convert.ToDouble(Console.ReadLine());

            var successfulFoodResult = member.RequestFoodAssistance(new Space(street, address), familySize, totalIncome);
            Console.WriteLine(successfulFoodResult);
        }

        static void RequestTranslatorData(Member member)
        {
            Console.Write("Please enter the street name: ");
            string street = Console.ReadLine();

            Console.Write("Please enter the address number: ");
            int address = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the language that must be translated: ");
            string language = Console.ReadLine();

            Console.Write("Please enter the year of the appointment: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the month number of the appointment: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the day of the appointment: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the hour of the appointment: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the minute of the appointment: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            var successfulTranslationResult = member.RequestTranslatorSession(
                                                    new Space(street, address), 
                                                    language, 
                                                    new DateTime(year, month, day, hour, minute, 0));
            Console.WriteLine(successfulTranslationResult);
        }
    }
}
