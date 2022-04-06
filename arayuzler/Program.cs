using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.writeLog();

            SmsLogger smsLogger = new(); // C# 9 ile yapılabilir
            smsLogger.writeLog();

            // her yerden kullanilabilir 
            LogManager logManager = new LogManager(new FileLogger()); // instance'ı olusuturuldu
            logManager.writeLog();
        }
    }
}
