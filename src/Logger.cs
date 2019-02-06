using System;
using System.IO;
using vlcollab_server.src;

namespace vlcollab_server.src
{
    public static class Logger
    {
        private static string path;
        static Logger() {
            path = ConfigManager.getLoggerPath();
            Console.WriteLine($"Initialized logger with file: <{path}>");
        }

        public static void Log(string text) {
            if(File.Exists(path)) {
                File.Create(path);
            }
            System.Console.WriteLine(text);
            File.AppendAllLines(path, new List<string>(text));
        }
    }
}