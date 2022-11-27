using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectureImplementation
{
    // Represents a session with a translator
    class TranslatorSession
    {
        private Space location;
        private string language;
        DateTime dateTime;
        TranslatorDB translatorDB;

        public TranslatorSession(Space location, string language, DateTime dateTime)
        {
            this.location = location;
            this.language = language;
            this.dateTime = dateTime;
            translatorDB = new TranslatorDB();
        }

        //Used to save request in DB using a DB connection class. Returns true on successful save.
        public bool SaveSession()
        {
            return translatorDB.AddSessionToDB(this);
        }
    }
}
