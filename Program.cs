using System;
using System.Collections.Generic;
using LawyerOffice.Contracts;
using LawyerOffice.Implementation;
using LawyerOffice.Service;

namespace LawyerOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lawyer lawyer = new Lawyer();
            var bringmeacoffee = FOODTYPE.Coffee;
            var translatethis = lawyer.Documento = "Ciao";

            OfficeManager officemanager = new OfficeManager();

            officemanager.ordinaTraduzione(LANGUAGE.ENG, translatethis);

            officemanager.ordinaCibo(bringmeacoffee);
            //enum tipo col pranzo cena
            /*
            Dizionario<Glovo,Mcdonalds>
                Dizionario<Glovo, Starbucks>
                Dizionario<Justeat, Mcdonalds>
                Dizionario<Justeat, Pizzeria>
            */

        }

        public class Lawyer
        {
            public string Cibo { get; set; }
            public string Documento { get; set; }
        }

        public class OfficeManager
        {           
            public TranslationOffice _translationOffice { get; set; }
            public DeliveryOffice _deliveryOffice { get; set; }
            public OfficeManager()
            {
                _translationOffice = new TranslationOffice();
                _deliveryOffice = new DeliveryOffice();
            }

            public void ordinaTraduzione(LANGUAGE lang, string text)
            {
                Console.WriteLine(_translationOffice.Translate(lang, text));
            }

            public void ordinaCibo(FOODTYPE food)
            {
                Console.Write(_deliveryOffice.GetCibo(food));
            }

            public void ordinaTask()
            {

            }
        }
    }
}
