using System;
using UnityEditor;

    public static class UnityBuildScript
    {
        public static void BuildProject()
        {
            // Set Build Version
            var buildVersion = GetArgsFromCommand("-BuildVersion");
            PlayerSettings.bundleVersion = buildVersion;

            // Get filename
            var JenkinsDirectory = GetArgsFromCommand("-JenkinsDirectory");

            // Get Unity Scenes
            string[] scenes = { "Main" };

            // Build Project
            string error = BuildPipeline.BuildPlayer(scenes, JenkinsDirectory + "UnityProject.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
            EditorApplication.Exit(string.IsNullOrEmpty(error) ? 0 : 1);
        }

        private static string GetArgsFromCommand(string argName)
        {
            var args = Environment.GetCommandLineArgs();
            for (var i = 0; i < args.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(args[i]);
                if (args[i] == argName && args.Length > i + 1)
                {
                    return args[i + 1];
                }
            }
            return null;
        }
    }
