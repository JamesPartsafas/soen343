using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectureImplementation
{
    //Represents a DB connection for food items. Here, the DB is represented with a List object
    class FoodDB
    {
        IList<FoodRequest> foodRequests;

        public FoodDB()
        {
            foodRequests = new List<FoodRequest>();
        }

        // Saves foodRequest item and returns true if successful
        public bool SaveRequest(FoodRequest foodRequest)
        {
            if (foodRequest == null)
                return false;

            foodRequests.Add(foodRequest);

            return true;
        }
    }
}
