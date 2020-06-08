﻿using System.IO;
using System.Reflection;

namespace GitFlowVS.Extension
{
    public static class GitFlowVersion
    {

        private static string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private static string GetFileInstallation()
        {
            return Path.Combine(Assembly.GetExecutingAssembly().Location, GetVersion());
        }

        public static bool IsFirstInstallation()
        {
            var path = GetFileInstallation();

            if (File.Exists(path))
                return false;
            return true;
        }


        public static void InstallFileVersion()
        {
            var path = GetFileInstallation();

            File.Create(path);
        }

    }
}