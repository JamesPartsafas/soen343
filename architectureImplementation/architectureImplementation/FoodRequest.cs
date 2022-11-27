using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectureImplementation
{
    // Represents a request for food
    class FoodRequest
    {
        private Space address;
        private int numOfFamilyMembers;
        private double totalIncome;
        private FoodDB foodDb;

        public FoodRequest(Space address, int numOfFamilyMembers, double totalIncome)
        {
            this.address = address;
            this.numOfFamilyMembers = numOfFamilyMembers;
            this.totalIncome = totalIncome;
            foodDb = new FoodDB();
        }

        //Used to save request in DB using a DB connection class. Returns true on successful save.
        public bool SaveRequest()
        {
            return foodDb.SaveRequest(this);
        }
    }
}
