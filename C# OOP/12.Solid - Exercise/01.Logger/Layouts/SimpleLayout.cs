using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Logger.Layouts.Contracts
{
    public class SimpleLayout : ILayout
    {
        //defines the format <date-time> - <report level> - <message>.
        public string Format => "{0} - {1} - {2}";
    }
}
