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
            var upcomingEvents = em.SearchUpcomingEvents();
            var chosenEvent = upcomingEvents.FirstOrDefault();

            if (chosenEvent == null)
                return "No events were found";

            return em.VolunteerForEvent(this, chosenEvent);
        }
    }
}
