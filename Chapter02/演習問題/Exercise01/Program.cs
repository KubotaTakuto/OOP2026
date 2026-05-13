
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var songs = new List<Song>();
            while (true) {
                //"曲名:"を出力
                Console.Write("曲名：");
                string? Title = Console.ReadLine();
                if (Title.ToLower() == "end") {
                    break;
                }
                //"アーティスト名:"を出力
                Console.Write("アーティスト名：");
                string? ArtistName = Console.ReadLine();
                //"演奏時間:"を出力
                Console.Write("演奏時間：");
                int Length = int.Parse(Console.ReadLine());
                //Console.ReadLine();//←
                Song song = new Song(Title, ArtistName, Length);

                songs.Add(song);

                // 2.1.3
                //            var songs = new Song[] {
                //                new Song("Let it be", "The Beatles", 243),
                //                new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
                //                new Song("Close To You", "Carpenters", 276),
                //                new Song("Honesty", "Billy Joel", 231),
                //                new Song("I Will Always Love You", "Whitney Houston", 273),
            };
            PrintSongs(songs);
        }

        //Mainメソッド内のPrintSongs(songs);をクリックして
        //Alt+Enterを押すと、以下のメソッドが自動的に生成される
        //2.1.4
        private static void PrintSongs(List<Song> songs) {
            foreach (var Song in songs) {
                Console.Write($"曲名：{Song.Title}");
                Console.Write($"　アーティスト名：{Song.ArtistName}");
                Console.WriteLine($"　演奏時間：{Song.Length / 60}:{Song.Length % 60:00}");
            }
        }
    }
}
