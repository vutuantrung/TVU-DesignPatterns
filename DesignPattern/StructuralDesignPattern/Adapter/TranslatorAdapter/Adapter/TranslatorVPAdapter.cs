using Adapter.TranslatorAdapter.Adaptee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.TranslatorAdapter.Adapter
{
    public class TranslatorVPAdapter : ITargetVietnamese
    {
        private JapaneseAdaptee _adaptee;

        public TranslatorVPAdapter( JapaneseAdaptee adaptee )
        {
            _adaptee = adaptee;
        }

        public void Send( string word )
        {
            string translatedWord = this.TranslateWord( word );

            _adaptee.Receive( translatedWord );
        }

        /// <summary>
        /// Translating method
        /// </summary>
        /// <param name="word">Vietnamese word need to be translated</param>
        /// <returns></returns>
        private string TranslateWord( string word )
        {
            // Logic code for translating
            if( word == "Xin chao") return "こんにちは";

            // return result
            return string.Empty;
        }
    }
}
