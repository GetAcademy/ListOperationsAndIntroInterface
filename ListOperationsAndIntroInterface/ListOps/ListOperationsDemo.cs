using System.Text.Json;

namespace ListOperationsAndIntroInterface.ListOps
{
    internal class ListOperationsDemo
    {
        private ChessPlayer[] _chessPlayers;

        /* Pause 9:42
         *
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
        public ListOperationsDemo()
        {
            var json = File.ReadAllText("chessplayers.json");
            _chessPlayers = JsonSerializer.Deserialize<ChessPlayer[]>(json);
        }

        public void Run()
        {
            var caruana = FindPlayerByStartOfName("Caruana");
            caruana?.Show();
            //if (caruana != null)
            //{
            //    caruana.Show();
            //}

        }

        private ChessPlayer FindPlayerByStartOfName(string startOfName)
        {
            foreach (var chessPlayer in _chessPlayers)
            {
                if (chessPlayer.Name.StartsWith(startOfName)) return chessPlayer;
            }
            return null;
        }

        private ChessPlayer? FindPlayerByStartOfName2(string startOfName)
        {
            return _chessPlayers.FirstOrDefault(chessPlayer => chessPlayer.Name.StartsWith(startOfName));
        }
    }
}
