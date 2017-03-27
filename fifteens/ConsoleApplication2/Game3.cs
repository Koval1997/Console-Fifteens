using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteens
{
    class Game3 : Game2, IPlayable
    {
        private List<string> movesHistory;

        public Game3(params int[] values) 
            : base(values)
        {

            movesHistory = new List<string>();
        }

        public override bool IsFinished(Game field)
        {
            return base.IsFinished(field);
        }

        public override void Shift(int value)
        {
            base.Shift(value);
            movesHistory.Add(string.Format("{0} with coordinate ({1}:{2}) replaced to ({3}:{4})", value, Dictionary[value].X, Dictionary[value].Y, Dictionary[0].X, Dictionary[0].Y));
        }

        public string GetStep(int value)
        {
            return movesHistory[value - 1];
        }

        public override void Randomize()
        {
            base.Randomize();
        }
    }
}
