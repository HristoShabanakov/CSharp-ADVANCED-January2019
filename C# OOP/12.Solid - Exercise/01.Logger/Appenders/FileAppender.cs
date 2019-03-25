
namespace _01.Logger.Appenders
{
    using Layouts.Contracts;
    using Appenders.Contracts;
    using System;
    using System.IO;
    using Loggers.Contracts;
    using Loggers.Enums;

    public class FileAppender : Appender
    {
        private ILogFile logFile;
        private const string Path = @"..\..\..\log.txt";

        public FileAppender(ILayout layout, ILogFile logFile)
            :base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                this.MessagesCount++;
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) + Environment.NewLine;
                this.logFile.Write(content);
                File.AppendAllText(Path, content);
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.ReportLevel.ToString().ToString().ToUpper()}, Messages appended: {this.MessagesCount}, " +
                $"File size: {this.logFile.Size}";
        }
    }
}
