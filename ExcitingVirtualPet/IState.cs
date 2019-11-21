using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    interface IState
    {
        void Eating();
        void Drinking();
        void Sleeping();
        void Playing();

    }
}
