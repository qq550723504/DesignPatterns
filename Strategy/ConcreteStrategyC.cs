﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ConcreteStrategyC:Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法C实现");
        }
    }
}
