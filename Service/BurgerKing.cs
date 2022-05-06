using LawyerOffice.Contracts;
using LawyerOffice.Implementation;

namespace LawyerOffice.Service
{
    internal class BurgerKing : IFood
    {
        public string Getfood(FOODTYPE food)
        {
            return $"Il {food.ToString()} sta arrivando";
        }
    }
}
