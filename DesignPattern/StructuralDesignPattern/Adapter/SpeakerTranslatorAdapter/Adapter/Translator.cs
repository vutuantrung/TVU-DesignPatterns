using Adapter.SpeakerTranslatorAdapter.Adaptee;
using Adapter.SpeakerTranslatorAdapter.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.SpeakerTranslatorAdapter.Adapter
{
    public class Translator : ITarget
    {
        private EnglishMan englishMan = new EnglishMan();
        private FrenchMan frenchMan = new FrenchMan();

        public string TranslateAndTellToOtherPerson( string words, Nationality language )
        {
            if ( language == Nationality.English )
            {
                string englishWords = ConvertToEnglish( words );

                string replyFromEnglishMan = englishMan.AnswerForTheQuestion( englishWords );

                string frenchConvertedWords = ConvertToFrench( replyFromEnglishMan );

                return frenchConvertedWords;
            }

            if ( language == Nationality.French )
            {
                string frenchWords = this.ConvertToFrench( words );

                string replyFromFrenchMan = frenchMan.AnswerFortheQuestion( frenchWords );

                string englishConvertdWords = this.ConvertToEnglish( replyFromFrenchMan );

                return englishConvertdWords;
            }

            return string.Empty;
        }

        public string ConvertToEnglish( string words )
        {
            if ( words == "Comment allez-vous?" ) return "How are you?";
            if ( words == "Je suis très bien, merci." ) return "I am fine, thank you.";
            if ( words == "Où êtes-vous?" ) return "where are you?";

            return "Can not convert.";
        }

        public string ConvertToFrench( string words )
        {
            if ( words == "How are you?" ) return "Comment allez-vous?";
            if ( words == "I am fine, thank you." ) return "Je suis très bien, merci.";
            if ( words == "Where are you?" ) return "Où êtes-vous?";

            return "On ne peut pas convertir.";
        }
    }
}
