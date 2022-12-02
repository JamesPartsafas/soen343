using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectureImplementation
{
    //Represents user giving requests for various actions to the system
    class Member
    {
        public string RequestFoodAssistance(Space address, int numOfFamilyMembers, double totalIncome)
        {
            return new FoodAssistanceManager().RequestFood(address, numOfFamilyMembers, totalIncome);
        }

        public string RequestTranslatorSession(Space location, string language, DateTime dateTime)
        {
            return new TranslatorManager().CreateTranslatorSession(location, language, dateTime);
        }

        public string VolunteerForEvent()
        {
            var em = new EventManager();
            var upcomingEvents = em.SearchUpcomingEvents().ToArray();
            
            Console.WriteLine();
            
            for (int i = 0; i < upcomingEvents.Count(); i++)
                Console.WriteLine(i + ") {0,5} {1,10} {2,-10}", upcomingEvents[i].date, upcomingEvents[i].name, upcomingEvents[i].description);

            Console.Write("\nPlease enter the number of event you want to volunteer for: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id < 0 || id >= upcomingEvents.Length)
            {
                return "Invalid Data Input";
            }

            var chosenEvent = upcomingEvents[id];

            return em.VolunteerForEvent(this, chosenEvent);
        }
    }
}
