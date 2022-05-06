using System;
using LawyerOffice.Service;
using LawyerOffice.Contracts;

namespace LawyerOffice.Implementation
{
    public class TranslationStore
    {
        public LANGUAGE _lang { get; set; }
        public ITranslator _translator { get; set; }

        public TranslationStore()
        {

        }
        public string Translate(LANGUAGE lang, string text)
        {
            var translator = Factory.MethodFactory(lang);

            return translator.Translate(text);
        }

    }
}
