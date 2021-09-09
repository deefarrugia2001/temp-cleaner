using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace VSTempCleaner
{
    /// <summary>
    /// Base class has been set to repository since unlike its deriving classes,
    /// no actual path will be set. Paths will only be initialized in the constructors of the deriving classes.
    /// Hence there is no need to instantiate a copy of the base class.
    /// Each deriving class will have its own path since each class will be dedicated to a specific folder.
    /// </summary>
    public abstract class Repository
    {
        enum RecycleFlag
        {
            SHERB_NOCONFIRMATION = 0x00000001
        }

        [DllImport("Shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);

        /// <summary>
        /// Contains the absolute path of the folder containing the temporary files. (For instance: C:\Users\[USER]\AppData\Local\Temp).
        /// The accessibility modifier has been set to protected as the member needs to be accessed from deriving classes.
        /// </summary>
        protected string path;

        /// <summary>
        /// Retrieves the path correlating to the repository to be deleted.
        /// </summary>
        public string Path => path;

        /// <summary>
        /// Delete files and subfolders residing in the repository.
        /// </summary>
        public int Delete() 
        {
            int returnValue;

            try 
            {
                DirectoryInfo directory = new DirectoryInfo(path); //Locate directory with the given path.
                IEnumerable<DirectoryInfo> subDirectories = directory.EnumerateDirectories(); //Search for any subfolders.

                //Proceed with deletion of content in subfolders if there is at least one subfolder.
                if (subDirectories != null)
                {
                    //Iterate through each subfolder and delete accordingly.
                    foreach (DirectoryInfo subDirectory in subDirectories)
                    {
                        IEnumerable<FileInfo> subFiles = subDirectory.EnumerateFiles();

                        //Proceed with deletion if there is at least a single file.
                        if (subFiles != null)
                        {
                            //Iterate through each file in subfolders and delete accordingly.
                            foreach (FileInfo file in subFiles)
                                file.Delete();
                        }

                        subDirectory.Delete(true);
                    }
                }

                //Iterate through each file in the root folder and proceed with deletion.
                IEnumerable<FileInfo> files = directory.EnumerateFiles();
                foreach (FileInfo file in files)
                    file.Delete();

                /* As opposed to Java, when deleting files/directories, the Recycle Bin is not cleared.
                 * Therefore, Shell32.dll had to be imported in the class library and invoked
                 * in order to automatically clear the recycle bin without confirmation. */
                returnValue = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlag.SHERB_NOCONFIRMATION);
            }
            catch(Exception ex) when (ex is PathTooLongException || ex is SecurityException || ex is ArgumentException || ex is ArgumentNullException || ex is DirectoryNotFoundException || ex is UnauthorizedAccessException || ex is IOException) 
            {
                returnValue = -1;
            }

            return returnValue;
        }
    }
}
