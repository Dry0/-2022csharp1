namespace Variabeleopdr3
{
    internal class Program
    {
        //ga naar de file TwitchStream.cs in je solution explorer in visual studio
        static void Main(string[] args)
        {

            TwitchStream twitchStream = new TwitchStream("randomizer");
            twitchStream.SetTag("speedrun");
            Console.WriteLine("c# stream has the tag:");
            Console.WriteLine(twitchStream.GetTag());
        }

        //vul de ??? in
        internal class TwitchStream
        {
            private string tag;

            internal TwitchStream(string tag)
            {
                this.tag = tag;
            }
            internal string GetTag()
            {
                return tag;
            }

            internal void SetTag(string speedrun)//maak hier een variable: type: string, name: tag
            {
                this.tag = tag;
            }
        }
}