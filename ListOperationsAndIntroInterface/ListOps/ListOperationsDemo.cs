using System.Text.Json;

namespace ListOperationsAndIntroInterface.ListOps
{
    internal class ListOperationsDemo
    {
        /*
         * 1: Litt om å hente data fra nett
         *      Tabeller fra nettsider vha Excel
         *      Konvertere til JSON
         *      Klasser fra JSON
         *      JSON Deserialisering
         *
         * 2: Listeoperasjoner med og uten LINQ
         *      Finne et objekt ut fra bestemt feltverdi 
         *      Finne alle objekter ut fra bestemt feltverdi
         *       - eller telle
         *       - eller alle/ingen/noen
         *      Aggregeringer som min, max, sum, snitt
         *      Sortere
         *      Lage en ny liste med verdiene til et eller flere felt
         */
        public static void Run()
        {
            var json = File.ReadAllText("chessplayers.json");
            var chessPlayers = JsonSerializer.Deserialize<ChessPlayer[]>(json);
        }
    }
}
