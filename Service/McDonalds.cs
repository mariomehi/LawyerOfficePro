using LawyerOffice.Contracts;
using LawyerOffice.Implementation;

namespace LawyerOffice.Service
{
    internal class McDonalds : IFood, Icoffeeshop
    {

        public string Getfood(FOODTYPE food)
        {
            return $"Il {food.ToString()} sta arrivando";
        }
    }
}
