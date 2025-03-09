using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300106
{
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State state;

        public DoorMachine()
        {
            state = State.Terkunci;
        }

        public void KunciPintu()
        {
            state = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            state = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}
