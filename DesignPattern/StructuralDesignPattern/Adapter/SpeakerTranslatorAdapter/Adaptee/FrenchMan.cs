using Adapter.SpeakerTranslatorAdapter.Adapter;
using Adapter.SpeakerTranslatorAdapter.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.SpeakerTranslatorAdapter.Adaptee
{
    public class FrenchMan : IFrenchSpeakerAdapter
    {
        public string Name { get; set; }

        public string AskQuestion( string words )
        {
            Console.WriteLine( "Question Asked by french man [French Speaker and Can understand only French] : " + words );

            ITarget translator = new Translator();

            string replyFromEnglishMan = translator.TranslateAndTellToOtherPerson( words, Nationality.English );

            return replyFromEnglishMan;
        }

        public string AnswerFortheQuestion( string words )
        {
            string reply = "Je ne comprends pas.";

            if(words == "Comment allez-vous?" )
            {
                reply = "Je suis très bien, merci.";
            }

            return reply;
        }
    }
}
