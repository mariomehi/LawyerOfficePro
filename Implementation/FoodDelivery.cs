using LawyerOffice.Service;
using System;


namespace LawyerOffice.Implementation
{
    internal class FoodDelivery
    {
        
        public string GetCibo(FOODTYPE food)
        {
            var cibo = Factory.GetRistorante(food);

            return cibo.Getfood(food);
        }

    }
}
