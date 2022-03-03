using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Timer
    {
        public static string CurrentTime()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
