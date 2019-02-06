using System;
using System.Collections.Generic;
using System.IO;

namespace vlcollab_server
{
    public static class Logger
    {
        private static readonly string path;
        static Logger() {
            path = ConfigManager.GetLoggerPath();
            Console.WriteLine($"Initialized logger with file: <{path}>");
        }

        public static void Log(string text) {
            if(File.Exists(path)) {
                Directory.CreateDirectory(path);
                File.Create(path);
            }
            Console.WriteLine(text);
            File.AppendAllLines(path, new[] {text});
        }
    }
}