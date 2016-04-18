using System;
using System.IO;

namespace SingleResponsibility
{
    public class OrderLogger : IOrderLogger
    {
        public void Log(string message)
        {
            File.WriteAllText(@"c:\Test.txt", message);
        }
    }
}