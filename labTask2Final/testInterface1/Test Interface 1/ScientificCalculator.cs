﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_1
{
    class ScientificCalculator : ScientificCalculatorInterface
    {
        public double Logarithm(int x)
        {
            double res = Math.Log(x);
            return res;
        }

        public double Root(int x)
        {
            double res = Math.Sqrt(x);
            return res;
        }

        public int XtoY(int x, int y)
        {
            int res = Convert.ToInt32(Math.Pow(x, y));
            return res;
        }
    }
}
