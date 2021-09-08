using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTempCleaner
{
    public class Repository
    {
        /* path will contain the absolute path of the folder containing the temporary files. 
         * The accessibility modifier has been set to protected as the member needs to be accessed from deriving classes. */
        protected string path;
    }
}
