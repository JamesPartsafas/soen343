using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectureImplementation
{
    //Manages translator requests. Receives requests from members and handles it as necessary.
    class TranslatorManager
    {
        //Attempts to store translator request and returns string based on result
        public string CreateTranslatorSession(Space location, string language, DateTime dateTime)
        {
            if (location == null || String.IsNullOrEmpty(language) || dateTime == null)
                return "The data is invalid";

            var translatorSession = new TranslatorSession(location, language, dateTime);

            bool success = translatorSession.SaveSession();

            if (!success)
                return "There was an issue storing the data.";

            return "The translator session request was successfully saved.";
        }
    }
}
