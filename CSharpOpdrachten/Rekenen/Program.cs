namespace Rekenen
{
    internal class Program
    {
        //class variable
        string programTitle = "variable demo";
        int programWindowsPosx = 100;

        static void Main(string[] args)
        {
            //type naam

            // + - / * of += -= *= /=

            //local variables
            int xPos = 100;

            //xPos = xPos + 10; kan je gebruiken maar dit hieronder is makkelijker

            xPos += 10;

            // voor als je het wilt uitschrijven/ duidelijker maken wat erg gebeurd en het voegt toe aan de som dus 120 hier
            // int result = xPos + 10;
            //xPos = result;


            xPos++;
            xPos--;
            xPos += 3;
            xPos = xPos + 10 + 100 + 29;

            xPos = (10 + 9) * 8;



            Console.WriteLine(xPos);
        }
    }
}