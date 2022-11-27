using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectureImplementation
{
    //Manages food requests. Receives requests from members and handles it as necessary.
    class FoodAssistanceManager
    {
        //Attempts to store food request and returns string based on result
        public string RequestFood(Space address, int numOfFamilyMembers, double totalIncome)
        {
            if (address == null || numOfFamilyMembers < 1 || totalIncome < 0)
                return "The data is invalid";

            var foodRequest = new FoodRequest(address, numOfFamilyMembers, totalIncome);

            bool success = foodRequest.SaveRequest();

            if (!success)
                return "There was an issue storing the data.";

            return "The food request was successfully saved.";
        }
    }
}
