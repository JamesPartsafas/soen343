using System;
using System.Collections.Generic;
using System.Linq;

namespace architectureImplementation
{
    //Represents a DB connection for events. Here, the DB is represented with a List object
    class EventsDB
    {
        IList<PublicEvent> events;
        
        //Add events to represent the functionality of searching for events 
        public EventsDB()
        {
            events = new List<PublicEvent>()
            {
                new PublicEvent{ name="Soccer Match", description="Annual Soccer Match", date=DateTime.Today.AddDays(2)},
                new PublicEvent{ name="Basketball Match", description="Annual Basketball Match", date=DateTime.Today.AddDays(-20)},
                new PublicEvent{ name="Volleyball Match", description="Annual Volleyball Match", date=DateTime.Today}
            };
        }

        //Gets all the events that are occuring today or in the future
        public IEnumerable<PublicEvent> GetUpcomingEvents()
        {
            return events.Where(e => DateTime.Compare(e.date, DateTime.Today) >= 0);
        }

        // Add a member as a volunteer for an event
        public bool AddVolunteer(Member member, PublicEvent @event)
        {
            if (@event == null)
                return false;

            @event.volunteers.Add(member);

            return true;
        }
    }
}
