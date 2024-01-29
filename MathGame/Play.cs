using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class Play
    {
        public IGame _igame;

        public Play(IGame igame)
        {
            _igame = igame;
        }

        public void StartGame()
        {
            this._igame.play();
            Console.Clear();
        }
    }
}
