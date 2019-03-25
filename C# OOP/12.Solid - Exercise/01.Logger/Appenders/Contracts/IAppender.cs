
namespace _01.Logger.Appenders.Contracts
{
    using Loggers.Enums;


    public interface IAppender
    {
        void Append(string dateTime, ReportLevel reportLevel, string message);

        int MessagesCount { get; }

        ReportLevel ReportLevel { get; set; }
    }
}
