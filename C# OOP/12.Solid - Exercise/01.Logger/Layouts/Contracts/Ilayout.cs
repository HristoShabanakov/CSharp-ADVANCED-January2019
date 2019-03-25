using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Logger.Layouts.Contracts
{
    public interface ILayout
    {
        string Format { get; }
    }
}
