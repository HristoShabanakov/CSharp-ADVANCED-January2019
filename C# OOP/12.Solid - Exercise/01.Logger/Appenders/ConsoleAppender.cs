namespace _01.Logger.Appenders.Contracts
{
    using Layouts.Contracts;
    using Loggers.Enums;
    using System;

    public class ConsoleAppender : Appender
    {
        //Appends a log to the console, using the provided layout.
        

        public ConsoleAppender(ILayout layout)
            :base(layout)
        {
        }

       

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if(this.ReportLevel <= reportLevel)
            {
                this.MessagesCount++;
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.ReportLevel.ToString().ToUpper()}, Messages appended: {this.MessagesCount}";
        }
    }
}
