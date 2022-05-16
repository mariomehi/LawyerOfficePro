using LawyerOffice.Implementation;

namespace LawyerOffice.Contracts
{

    public interface IFood
    {
        public string Getfood(FOODTYPE food);
    }

    public interface IRestaurant : IFood
    {
        public new string Getfood(FOODTYPE food);
    }

    public interface Icoffeeshop : IFood
    {
        public new string Getfood(FOODTYPE food);
    }
}
