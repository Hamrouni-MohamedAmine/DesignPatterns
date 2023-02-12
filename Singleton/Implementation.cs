namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        // Lazy<T>
        // Making the implementation Thread-Safe with the Lazy<T> 
        private static readonly Lazy<Logger> _lazyLogger
            = new Lazy<Logger>(() => new Logger() );
        //private static Logger? _instance;

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;
            }
        }

        /// <summary>
        /// SingletonOperation for test purpose
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
