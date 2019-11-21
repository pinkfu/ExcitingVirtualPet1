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
