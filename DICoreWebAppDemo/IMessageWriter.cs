﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DICoreWebAppDemo
{
    public interface IMessageWriter
    {
        void Write(string message);
    }
}
