using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Implementation
{
    internal class TranslationOffice
    {
        TranslationStore _translationStore = new TranslationStore();

        public string Translate(LANGUAGE lang, string text)
        {
            return _translationStore.Translate(lang, text);
        }

    }
}
