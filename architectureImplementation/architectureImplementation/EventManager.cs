using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectureImplementation
{
    //Manages events search requests and voluteer requests. Receives requests from members and handles it as necessary.
    class EventManager
    {
        private EventsDB edb;

        public EventManager()
        {
            edb = new EventsDB();
        }

        //Propagates the search request to the database
        public IEnumerable<PublicEvent> SearchUpcomingEvents()
        {
            return edb.GetUpcomingEvents();
        }

        //Attempts to add the requesting member as a volunteer for an event and returns string based on result
        public string VolunteerForEvent(Member member, PublicEvent @event)
        {
            if (@event == null || member == null)
                return "The data is invalid";

            bool succes = edb.AddVolunteer(member, @event);

            if (!succes)
                return "There was an issue storing the data.";

            return "The volunteer request was successfully added.";
        }

    }
}
