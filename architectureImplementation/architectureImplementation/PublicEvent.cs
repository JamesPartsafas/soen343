using System;
using System.Collections.Generic;

namespace architectureImplementation
{
    //Represents an event on the website
    class PublicEvent
    {
        public IList<Member> volunteers { get; init; }
        public string name { get; init; }
        public string description { get; init; }
        public DateTime date { get; init; }

        public PublicEvent()
        {
            volunteers = new List<Member>();
        }
    }
}
