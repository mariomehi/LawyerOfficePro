using System;
using System.Collections.Generic;
using LawyerOffice.Contracts;
using LawyerOffice.Implementation;
using LawyerOffice.Service;
using LawyerOffice.Utility;

namespace LawyerOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lawyer lawyer = new Lawyer();
            //var bringmeacoffee = FOODTYPE.Dinner;
            var translatethis = lawyer.Documento = "Ciao";
            //var taska = TASKTYPE.fiscale;

            OfficeManager officemanager = new OfficeManager();

            //officemanager.ordinaTraduzione(LANGUAGE.ENG, translatethis);
            //officemanager.ordinaTask(taskamitutto);

            Food foodordered = new Food("Margherita");
            officemanager.Menu(foodordered);
            officemanager.ordinaCibo(foodordered, DateTime.Now);
        }

        public class LawyerOffice : IOfficeServices
        {
            public void ordinaCibo()
            {

            }

            public void ordinaTraduzione()
            {

            }
        }

        public class Lawyer
        {
            public string Cibo { get; set; }
            public string Documento { get; set; }
            public void ordinaCibo()
            {

            }

            public void ordinaTraduzione()
            {

            }
        }

        public class Employee
        {
            public void ordinaCibo()
            {

            }

            public void ordinaTraduzione()
            {

            }
        }

        public class OfficeManager
        {           
            //public TranslationOffice _translationOffice { get; set; }
            public DeliveryOffice _deliveryOffice { get; set; }
            public FoodDelivery foodDelivery = new FoodDelivery();
            DelegateperOra deleg;

            public OfficeManager()
            {
                //_translationOffice = new TranslationOffice();
                _deliveryOffice = new DeliveryOffice();
                deleg = FeedBack;
            }

            public void Menu(Food food)
            {
                var rest = foodDelivery.findR(food);
                var item = foodDelivery.GetMenu(rest);
                Console.WriteLine("Ristorante: "+rest._Name);
                foreach(var diz in item.Values)
                {
                    foreach (var list in diz)
                    {
                        Console.Write(list._nome+", ");
                    }
                    Console.Write("\n");
                }
            }

            public void ordinaCibo(Food food, DateTime date)
            {
                foodDelivery.ritornaL(date, food, deleg);
                var foodi = _deliveryOffice.ordinaCibo(food);
                Console.WriteLine(foodi._nome);
            }

            public void FeedBack(string message)
            {
                Console.WriteLine(message);
            }

            public void ordinaTask(TASKTYPE taskt)
            {
                //Console.WriteLine("Task: "+_deliveryOffice.GetTask(taskt));
            }
        }
    }
}
