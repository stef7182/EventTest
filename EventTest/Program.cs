using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    //public static event EventHandler _CallEvent;
    class Program
    {
        static void Main(string[] args)
        {
            Metronome metronome = new Metronome();
            Listener listener = new Listener();

            metronome.Tick += listener.Response;

            metronome.FireTick();
        }
    }
}
