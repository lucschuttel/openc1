using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OneAmEngine
{
    public static class Logger
    {
        static StreamWriter _file;

        public static void Log(string message)
        {
            if (_file == null)
            {
                _file = new StreamWriter("log.txt", false);
            }
            _file.WriteLine(message);
            _file.Flush();
        }
    }
}
