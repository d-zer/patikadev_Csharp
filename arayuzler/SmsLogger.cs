using System;

namespace arayuzler
{
    public class SmsLogger : ILogger
    {
        public void writeLog()
        {
            // throw new NotImplementedException(); // ihtiyacın yoksa yazmayabilirsin
            Console.WriteLine("Sms olarak log yazar.");
        }
    }
}