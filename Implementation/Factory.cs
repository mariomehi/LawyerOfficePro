using LawyerOffice.Contracts;
using LawyerOffice.Service;
using System;

namespace LawyerOffice.Implementation
{
    public static class Factory
    {
        //public static IFood GetRistorante(FOODTYPE forn)
        //{
        //    IFood food = null;
        //    switch (forn)
        //    {
        //        case FOODTYPE.Coffee:
        //            if (Utility.randomutil()==1) {
        //                food = new Starbucks();
        //            } else { food = new McDonalds(); }
                    
        //            break;
        //        case FOODTYPE.Launch:
        //            if (Utility.randomutil() == 1)
        //            {
        //                food = new BurgerKing();
        //            }
        //            else { food = new McDonalds(); }
        //            break;
        //        case FOODTYPE.Dinner:
        //            if (Utility.randomutil() == 1)
        //            {
        //                food = new McDonalds();
        //            }
        //            else { food = new BurgerKing(); }
        //            break;
        //        default:
        //            return null;
        //    }
        //    return food;
        //}


        /// La factory può generare piu tipi di oggetti
        //public static ITranslator MethodFactory(LANGUAGE lang)
        //{
        //    ITranslator translator = null;
        //    switch (lang)
        //    {
        //        case LANGUAGE.ENG:
        //            translator = new English();
        //            break;
        //        case LANGUAGE.GER:
        //            translator = new German();
        //            break;
        //        default:
        //            return null;
        //    }
        //    return translator;
        //}

        //public static ITask FactoryTask(TASKTYPE tasktype)
        //{
        //    ITask itask = null;
        //    switch (tasktype)
        //    {
        //        case TASKTYPE.fiscale:
        //            itask = new Commercialista();
        //            break;
        //        case TASKTYPE.legale:
        //            itask = new Praticante();
        //            break;
        //        default:
        //            return null;
        //    }
        //    return itask;
        //}
    }
    public static class Utility
    {
        public static int randomutil()
        {
            Random random = new Random();
            int num = random.Next(1, 3);
            return num;
        }

    }
}
