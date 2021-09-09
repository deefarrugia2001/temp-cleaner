namespace VSTempCleaner
{
    public class WinTemp : Repository
    {
        public WinTemp() : base() 
        {
            this.path = @"C:\Windows\Temp";
        }
    }
}