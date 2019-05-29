using System.IO;
using System.Collections.Generic;

namespace TextAdv.helpers
{
    /// <summary>
    /// Class, for giving Paths to files and Directories
    /// </summary>
    public static class Paths
    {
        /// <summary>
        /// Gives the Path to the Executing Directory
        /// </summary>
        /// <returns>The relative Path to the Directory of the .exe</returns>
        public static string GetRelativePath()
        {
            return Directory.GetCurrentDirectory();
        }

        /// <summary>
        /// Gives all files in a directory
        /// </summary>
        /// <param name="searchDir">The (starting) directory</param>
        /// <param name="recursive">differentiates between recursive search or normal search</param>
        /// <returns>A List of all found filepaths</returns>
        public static List<string> SearchAllFiles(string searchDir, bool recursive = true)
        {
            List<string> files = new List<string>();
            foreach (string f in Directory.GetFiles(searchDir))
            {
                files.Add(f);
            }

            if (!recursive) return files;
            foreach (string dir in Directory.GetDirectories(searchDir))
            {
                files.AddRange(SearchAllFiles(dir));
            }

            return files;
        }
    }
}