﻿using System;

namespace VSTempCleaner
{
    public sealed class UserTemp : Repository
    {
        public UserTemp() : base() 
        {
            this.path = $@"C:\Users\{Environment.UserName}\AppData\Local\Temp";
        }
    }
}