namespace _01.Logger.Appenders
{
    using Layouts.Contracts;
    using Appenders.Contracts;
    using Loggers.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        protected ILayout Layout { get; }

        public ReportLevel ReportLevel {get; set ;}

        public int MessagesCount { get; protected set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);
        
    }
}
