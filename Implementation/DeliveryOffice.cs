using LawyerOffice.Service;
using LawyerOffice.Utility;
using System;

namespace LawyerOffice.Implementation
{
    internal class DeliveryOffice
    {
        TaskDelivery taskdelivery = new TaskDelivery();
        FoodDelivery fooddelivery = new FoodDelivery();

        string ID { get; set; }
        string ReferenteDelivery { get; set; }
        int NumeroTelefono { get; set; }
        string email { get; set; }

        public Food ordinaCibo(Food food)
        {
            return fooddelivery.DeliveryOrder(food);
        }

        public string ordinaTask(TASKTYPE taskt)
        {
            //return taskdelivery.GetTask(taskt);
            return string.Empty;
        }
    }
}
