using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fifteens
{
    class Game2 : Game, IPlayable
    {

        public Game2(params int[] values)
            : base(values)
        {

        }

        public virtual void Randomize()
        {
            int[] values = new int[this.Side * this.Side];            

            for (int i = 0; i < this.Side; i++)
            {
                for (int j = 0; j < this.Side; j++)
                {
                    if (this[i, j].Number == 0)
                    {
                        if (this[i + 1, j].Number != 0)
                        {
                            this.Shift(this[i + 1, j].Number);
                        }
                    }
                }
            }

        }

        public virtual bool IsFinished(Game field)
        {
            int[] massive = new int[field.Side * field.Side];

            for (int i = 0; i < field.Side; i++)
            {
                for (int j = 0; j < field.Side - 1; j++)
                {
                    if (field[i, j].Number != field[i, j + 1].Number - 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override void Shift(int value)
        {
            base.Shift(value);
        }


    }
}