using LawyerOffice.Contracts;
using LawyerOffice.Implementation;
using System.Collections.Generic;

namespace LawyerOffice.Service
{
    public static class SigData
    {
        public static List<Restaurant> Init()
        {
            List<Food> f0 = new List<Food>() {
                new Food("Cappuccino"),
                new Food("Espresso"),
                new Food("Macchiatto") };
            List<Food> f1 = new List<Food>() {
                new Food("Apollo"),
                new Food("Camogli"),
                new Food("Tonno") };
            List<Food> f2 = new List<Food>() {
                new Food("Margherita"),
                new Food("Boscaiola"),
                new Food("Capricciosa") };

            Dictionary<FOODTYPE, List<Food>> d1 = new Dictionary<FOODTYPE, List<Food>>();
            d1.Add(FOODTYPE.Coffee, f0);
            d1.Add(FOODTYPE.Sandwich, f1);
            d1.Add(FOODTYPE.Pizza, f2);

            Dictionary<FOODTYPE, List<Food>> d2 = new Dictionary<FOODTYPE, List<Food>>();
            d2.Add(FOODTYPE.Coffee, f0);

            Dictionary<FOODTYPE, List<Food>> d3 = new Dictionary<FOODTYPE, List<Food>>();
            d3.Add(FOODTYPE.Sandwich, f1);
            d3.Add(FOODTYPE.Pizza, f2);


            List<Restaurant> ristoranti = new List<Restaurant>();
            ristoranti.Add(new Restaurant("Starbucks", RestaurantType.breakfast, d2));
            ristoranti.Add(new Restaurant("McDonalds", RestaurantType.launch, d1));
            ristoranti.Add(new Restaurant("BurgerKing", RestaurantType.dinner, d3));

            return ristoranti;

        }

    }
}
