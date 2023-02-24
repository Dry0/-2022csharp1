using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Variabeleopdr2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            string streamer;
            streamer = "Smallant";
            //lastStreamName, waarde: de streamname van de laatste keer
            string lastStreamName;
            lastStreamName = "Super Mario Oddesey online tournament";
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            string streamGame;
            streamGame = "Super Mario Oddesey";
            //followers, waarde: hoeveel followers
            int followers = 300000;
            //automod, waarde: staat automod aan?
            bool automodOn;


            Console.WriteLine($" streamer = {streamer}  lastStreamName = {lastStreamName}  followers = {followers}  streamGame = {streamGame} ");
        }
    }
    internal class Game
    {
        internal string name;

        internal Game(string name)//constructor
        {
            this.name = name;
        }
    }
    internal class TwitchStream
    {
        //maak hier class variables aan:
        // type=string, naam: name,
        // type=string, naam: lastStreamName
        // type=Game, naam: streamGame
        // type=int, naam: followers
        // type=bool, naam: automod


    }
}