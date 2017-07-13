using System;

namespace WingtipToys.Logic
{
    public static class ExceptionUtility
    {
        public static void LogException(Exception exc, string source = "main")
        {
            Console.WriteLine("$source: $exc.Message");
            Console.WriteLine(exc.StackTrace);
            if (exc.InnerException != null)
            {
                LogException(exc.InnerException);
            }
        }
    }
}