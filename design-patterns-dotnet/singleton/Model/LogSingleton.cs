namespace Singleton.Model
{
    public class LogSingleton
    {
        private static LogSingleton Instance;
        private LogSingleton()
        {
            
        }
        public static LogSingleton GetInstance()
        {
            if (Instance == null) 
                return new();
            return Instance;
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
