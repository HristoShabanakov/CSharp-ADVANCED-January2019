
namespace _01.Logger.Appenders.Contracts
{
    using Layouts.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
