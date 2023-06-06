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
            //var caruana = FindPlayerByStartOfName("Caruana");
            //caruana?.Show();

            //var peopleBelow30 = FindPlayersWithMaxAge(29);
            //foreach (var chessPlayer in peopleBelow30)
            //{
            //    chessPlayer.Show();
            //}

            //var sumRating = GetSumOfRatings();
            //Console.WriteLine(sumRating);

            //SortDemo();

            //var names = GetNames();
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            // array til liste
            string[] stringArray = new string[] {"Per", "Pål", "Espen"};
            List<string> stringList = stringArray.ToList();

            // liste til array
            List<int> intList = new List<int> { 1, 2, 3};
            int[] intArray = intList.ToArray();

            // LINQ Where returnerer IEnumerable<>
            IEnumerable<string> stringsStartingWithP = stringArray.Where(s=>s.StartsWith("P"));
        }

        private List<string> GetNames()
        {
            var names = new List<string>();
            foreach (var chessPlayer in _chessPlayers)
            {
                names.Add(chessPlayer.Name);
            }
            return names;
        }

        private List<string> GetNames2()
        {
            return _chessPlayers.Select(chessPlayer => chessPlayer.Name).ToList();
        }

        private void SortDemo()
        {
            var chessPlayersArray = _chessPlayers.ToArray();
            Array.Sort(chessPlayersArray); // dette endrer rekkefølgen på elementene i arrayen

            var mySortedChessPlayers = _chessPlayers.OrderBy(p => p.Name).ToList();
            var mySortedChessPlayers2 = _chessPlayers.OrderByDescending(p => p.Name).ToList();
        }

        private float GetSumOfRatings()
        {
            var sumRatings = 0f;
            foreach (var chessPlayer in _chessPlayers)
            {
                sumRatings += chessPlayer.Classic;
            }
            return sumRatings;
        }

        private float GetSumOfRatings2()
        {
            return _chessPlayers.Sum(chessPlayer => chessPlayer.Classic);
            //return _chessPlayers.Max(chessPlayer => chessPlayer.Classic);
            //return _chessPlayers.Min(chessPlayer => chessPlayer.Classic);
            //return _chessPlayers.Average(chessPlayer => chessPlayer.Classic);
        }

        private List<ChessPlayer> FindPlayersWithMaxAge(int maxAge)
        {
            var chessPlayers = new List<ChessPlayer>();
            foreach (var chessPlayer in _chessPlayers)
            {
                if (chessPlayer.Age <= maxAge)
                {
                    chessPlayers.Add(chessPlayer);
                }
            }
            return chessPlayers;
        }

        private List<ChessPlayer> FindPlayersWithMaxAge2(int maxAge)
        {
            return _chessPlayers.Where(chessPlayer => chessPlayer.Age <= maxAge).ToList();
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
