using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTempCleaner
{
    public class Repository
    {
        /// <summary>
        /// Contains the absolute path of the folder containing the temporary files. (For instance: C:\Users\[USER]\AppData\Local\Temp).
        /// The accessibility modifier has been set to protected as the member needs to be accessed from deriving classes.
        /// </summary>
        protected string path;
    }
}
