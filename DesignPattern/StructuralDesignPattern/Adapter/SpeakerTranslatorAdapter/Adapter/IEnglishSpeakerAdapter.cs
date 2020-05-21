using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.SpeakerTranslatorAdapter.Adapter
{
    public interface IEnglishSpeakerAdapter
    {
        string AskQuestion( string words );
        string AnswerForTheQuestion( string words );
    }
}
