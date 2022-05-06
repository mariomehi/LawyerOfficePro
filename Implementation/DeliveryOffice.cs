using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Implementation
{
    internal class DeliveryOffice
    {
        TaskDelivery taskdelivery = new TaskDelivery();
        FoodDelivery fooddelivery = new FoodDelivery();

        //DeliveryService
        //

        public string GetCibo(FOODTYPE food)
        {
            return fooddelivery.GetCibo(food);
        }

        public void GetTask()
        {

        }
    }
}
