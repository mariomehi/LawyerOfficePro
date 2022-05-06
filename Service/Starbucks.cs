using LawyerOffice.Contracts;
using LawyerOffice.Implementation;

namespace LawyerOffice.Service
{
    internal class Starbucks : Icoffeeshop
    {
        public string Getfood(FOODTYPE food)
        {
            return $"eccoti il tuo {food.ToString()} ";
        }

    }
}
