using System;

namespace VSTempCleaner
{
    class UserTemp : Repository
    {
        public UserTemp() : base() 
        {
            this.path = $@"C:\Users\{Environment.UserName}\AppData\Local\Temp";
        }
    }
}