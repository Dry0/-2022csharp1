namespace FunctionsUitleg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Program program = new Program();
            string report = program.GetWeatherReport();

            Console.WriteLine(report);
            program.WriteWeatherReport(report);
            program.SetPlayerPosition(1, 5, 0);

        }

        private void SetPlayerPosition(float x, float y,int z)
        {
            
      
        }

        private void SetPlayerPosition(int x, float y, int z)
        {


        }

        private void WriteWeatherReport(string report) 
        {
            Console.WriteLine(report);
        }

        private GameEngine MakeGameEngine() 
        {
            return new GameEngine();
        }

        private string GetWeatherReport()
        {
            string report = "24 graden geen regen";
            
            
            return report;
        }
    }
}