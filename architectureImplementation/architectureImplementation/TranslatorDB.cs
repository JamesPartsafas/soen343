using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectureImplementation
{
    //Represents a DB connection for translator sessions. Here, the DB is represented with a List object
    class TranslatorDB
    {
        IList<TranslatorSession> translatorSessions;

        public TranslatorDB()
        {
            translatorSessions = new List<TranslatorSession>();
        }

        // Saves translatorSession item and returns true if successful
        public bool AddSessionToDB(TranslatorSession translatorSession)
        {
            if (translatorSession == null)
                return false;

            translatorSessions.Add(translatorSession);

            return true;
        }
    }
}
