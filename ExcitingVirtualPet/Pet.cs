using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    class Pet : IPet
    {
        //pet Constants
        const int MAX_HUNGER = 10;
        const int MIN_HUNGER = 0;
        const int MAX_AFFECTION = 10;
        const int MIN_AFFECTION = 0;
        const int MAX_THIRST = 10;
        const int MIN_THIRST = 0;
        const int MAX_BOREDOM = 10;
        const int MIN_BOREDOM = 0;

        const int MAX_FOOD = 10;
        const int MIN_FOOD = 0;
        const int MAX_WATER = 10;
        const int MIN_WATER = 0;

        //Time Stuff
        Timer mainLoopTimer;
        int hungerFrame;
        int thirstFrame;
        int boredomFrame;
        int affectionFrame;
        int eatFrame;
        int drinkFrame;
        int hungerCounter;
        int thirstCounter;
        int boredomCounter;
        int affectionCounter;
        int eatCounter;
        int drinkCounter;

        //Add States
        //Normal State
        //Eating State
        //Drinking State
        //Sleeping State


        //Pet constructor needs to take in name and create instance of normal state
        public Pet()
        {

        }
        public void DoAThing()
        {
            if (hungerCounter >= hungerFrame)
            {
                increaseHunger();

            }
            if (thirstCounter >= thirstFrame)
            {
                increaseThirst();

            }
            if (affectionCounter >= affectionFrame)
            {
                decreaseAffection();

            }
            if (boredomCounter >= boredomFrame)
            {
                increaseBoredom();

            }
            //update cat need fulfillment
            if (catDrinking)
            {
                drinkCounter++;
                if (drinkCounter >= drinkFrame)
                {
                    tryToDrink();
                }
            }
            if (catEating)
            {
                eatCounter++;
                if (eatCounter >= eatFrame)
                {
                    tryToEat();
                }
            }
        }
        public void Hungry()
        {
            throw new NotImplementedException();
        }

        public void Lonely()
        {
            throw new NotImplementedException();
        }

        public void Sleepy()
        {
            throw new NotImplementedException();
        }

        public void Thirsty()
        {
            throw new NotImplementedException();
        }
    }
}
