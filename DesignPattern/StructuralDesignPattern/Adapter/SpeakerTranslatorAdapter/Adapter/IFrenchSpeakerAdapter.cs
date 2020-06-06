using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.SpeakerTranslatorAdapter.Adapter
{
    public interface IFrenchSpeakerAdapter
    {
        string AskQuestion( string words );
        string AnswerFortheQuestion( string words );
    }
}
