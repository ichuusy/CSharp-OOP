﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearn
{
    internal interface IBuilder
    {
        void BuildApartment(int floor);
        void DestroyApartment();
    }
}
