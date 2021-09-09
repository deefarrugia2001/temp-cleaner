namespace VSTempCleaner
{
    public sealed class WinTemp : Repository
    {
        public WinTemp() : base() 
        {
            this.path = @"C:\Windows\Temp";
        }
    }
}