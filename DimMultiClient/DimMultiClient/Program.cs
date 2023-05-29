using DimMultiClient.Enums;
using TsadriuUtilities;

namespace DimMultiClient
{
    internal static class Program
    {
        private static VersionEnum currentVersion = VersionEnum.V1_0_2;
        public static DimMultiClientLauncher Launcher = null!;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Launcher = new DimMultiClientLauncher
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            Application.Run(Launcher);
        }

        /// <summary>
        /// Returns the current version as a string. Note that is removes the V and replaces the <b>_</b> with a <b>.</b> found in <see cref="VersionEnum"/>.
        /// </summary>
        /// <returns><see cref="currentVersion"/> as "Version x.x.x" (<see cref="VersionEnum.V1_0_0"/> returns Version 1.0.0 and so on).</returns>
        public static string GetVersionAsString()
        {
            return $"Version {currentVersion.ToString().Remove("V").Replace("_", ".")}";
        }
    }
}