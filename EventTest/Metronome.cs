using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{

    public delegate void DG_MetronomeTick();
    
    class Metronome
    {

        public event DG_MetronomeTick Tick;

        public void FireTick()
        {
            for (int i = 0; i < 5; i++)
            {
                Tick();
                System.Threading.Thread.Sleep(3000);

            }
        }

    }
}
