using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    class PetState : IState
    {
        IState state;
        public IState State
        {
            set { state = value; }
        }
        const int MAX_FOOD = 10;
        const int MIN_FOOD = 0;
        const int MAX_WATER = 10;
        const int MIN_WATER = 0;
        public PetState()
        {
            state = new ();
        }

        public void Drinking()
        {
           
        }

        public void Eating()
        {
            throw new NotImplementedException();
        }

        public void Playing()
        {
            throw new NotImplementedException();
        }

        public void Sleeping()
        {
            throw new NotImplementedException();
        }
    }
    
}
