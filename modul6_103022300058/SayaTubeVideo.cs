using System;


namespace modul6_103022300058
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title) {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count) {
            playCount += count;
        }

        public void PrintVideoDetails(){
            Console.WriteLine("ID: " + id );
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Playcount: " + playCount);
        }

        public int GetPlayCount() {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
