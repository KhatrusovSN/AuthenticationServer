﻿using System;

namespace AuthenticationServer
{
    public class Logger : ILogger
    {
        public void WriteEvent(string eventMessage)
        {
            Console.WriteLine(eventMessage);
        }

        public void WriteError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
