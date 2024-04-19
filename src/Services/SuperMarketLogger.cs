namespace CodingExercise.Services
{
    public interface ISuperMarketLogger
    {
        void Log(string message);
    }

    public class SuperMarketLogger : ISuperMarketLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
