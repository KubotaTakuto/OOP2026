
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            // 2.1.3
            var songs = new Song[] {
                new Song("Let it be", "The Beatles", 243),
                new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
                new Song("Close To You", "Carpenters", 276),
                new Song("Honesty", "Billy Joel", 231),
                new Song("I Will Always Love You", "Whitney Houston", 273),
};
            PrintSongs(songs);
        }
        //Mainメソッド内のPrintSongs(songs);をクリックして
        //Alt+Enterを押すと、以下のメソッドが自動的に生成される
        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var Song in songs) {
                Console.WriteLine("曲名：" + Song.Title);
                Console.WriteLine("アーティスト名：" + Song.ArtistName);
                if (Song.Length % 60 >= 10) {
                    Console.WriteLine("演奏時間：" + Song.Length / 60 + ":" + Song.Length % 60);
                } else {
                    Console.WriteLine("演奏時間：" + Song.Length / 60 + ":0" + Song.Length % 60);
                }
            }
        }
    }
}
