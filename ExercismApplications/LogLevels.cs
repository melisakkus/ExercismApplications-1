namespace ExercismApplications
{
    internal class LogLevels
    {
        public static string Message(string logLine)
        {
            int index = logLine.IndexOf(":");
            return logLine.Substring(index + 1).Trim();
        }

        public static string LogLevel(string logLine)
        {
            int firstIndex = logLine.IndexOf("[") + 1;
            int lastIndex = logLine.IndexOf("]");
            return logLine.Substring(firstIndex, lastIndex - firstIndex).ToLower();
        }
    
        public static string Reformat(string logLine)
        {
            string message = Message(logLine);
            string logLevel = LogLevel(logLine);
            return $"{message} ({logLevel})";
        }
    }
}

//Instructions
//In this exercise you'll be processing log-lines.
//Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>".
//There are three different log levels:
//INFO
//WARNING
//ERROR
//You have three tasks, each of which will take a log line and ask you to do something with it.
//Implement the (static) LogLine.Message() method to return a log line's message:
//LogLine.Message("[ERROR]: Invalid operation")
//// => "Invalid operation"
//Any leading or trailing white space should be removed:
//LogLine.Message("[WARNING]:  Disk almost full\r\n")
//// => "Disk almost full"
//Opens in a modal
//Implement the (static) LogLine.LogLevel() method to return a log line's log level, which should be returned in lowercase:
//LogLine.LogLevel("[ERROR]: Invalid operation")
//// => "error"
//Opens in a modal
//Implement the (static) LogLine.Reformat() method that reformats the log line, 
//    putting the message first and the log level after it in parentheses:
//LogLine.Reformat("[INFO]: Operation completed")
//// => "Operation completed (info)"

