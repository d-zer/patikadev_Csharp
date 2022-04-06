using System;

namespace arayuzler
{
    public class LogManager:ILogger
    {
        public ILogger _logger; // interface'in referansi
        public LogManager(ILogger logger)
        {
            _logger = logger;

        }

        public void writeLog()
        {
            // throw new NotImplementedException();
            _logger.writeLog();
        }
    }
}