﻿namespace _01.Logger.Layouts.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);

    }
}
