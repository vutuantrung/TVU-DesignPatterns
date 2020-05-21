using Adapter.SpeakerTranslatorAdapter.Adapter;
using Adapter.SpeakerTranslatorAdapter.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.SpeakerTranslatorAdapter.Adaptee
{
    public class EnglishMan : IEnglishSpeakerAdapter
    {
        public string Name { get; set; }

        public string AskQuestion( string words )
        {
            Console.WriteLine( "Question Asked by english man [English Speaker and Can understand only English] : " + words );

            ITarget translator = new Translator();

            string replyFromFrenchMan = translator.TranslateAndTellToOtherPerson( words, Nationality.French );

            return replyFromFrenchMan;
        }

        public string AnswerForTheQuestion( string words )
        {
            string reply = "I do not understand.";

            if(words == "How are you?" )
            {
                reply = "I am fine, thank you.";
            }

            return reply;
        }
    }
}
