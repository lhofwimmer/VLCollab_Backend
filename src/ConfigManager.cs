using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace vlcollab_server.src
{
    public static class ConfigManager
    {
        private static string path;
        private static List<string> config;


        static ConfigManager() {
            path = Directory.GetCurrentDirectory()+@"\config";
            config = File.ReadAllLines($@"{path}\config.cfg").ToList();
        }

        public static string getLoggerPath() => config[0];
    }
}