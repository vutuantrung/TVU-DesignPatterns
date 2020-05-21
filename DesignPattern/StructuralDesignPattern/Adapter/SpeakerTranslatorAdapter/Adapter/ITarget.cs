using Adapter.SpeakerTranslatorAdapter.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.SpeakerTranslatorAdapter.Adapter
{
    public interface ITarget
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="words">The words need to be sent</param>
        /// <param name="language">The language will be translated to</param>
        /// <returns></returns>
        string TranslateAndTellToOtherPerson( string words, Nationality language );
    }
}
