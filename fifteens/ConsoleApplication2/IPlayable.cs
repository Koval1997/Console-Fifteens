﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteens
{
    interface IPlayable
    {
        int SizeOfField { get; }
        void Randomize();
        bool IsFinished(Game field);
        void Shift(int value); 
    }
}
