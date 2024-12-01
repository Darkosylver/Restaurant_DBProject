// sourced from: https://dusted.codes/dotenv-in-dotnet
using System;
using System.IO;

namespace Restaurant_DB
{
    public static class envHandler
    {
        public static void Load(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                char[] separators= { '=' };
                var parts = line.Split(separators, options: StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                    continue;

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
    }
}
