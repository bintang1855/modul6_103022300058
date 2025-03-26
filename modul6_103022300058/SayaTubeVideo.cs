using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;


namespace modul6_103022300058
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title) {

            Contract.Requires(title != null, "Judul video tidak boleh kosong");
            Contract.Requires(title.Length <= 200, "Judul video tidak boleh lebih dari 200 karakter");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count) {
            Contract.Requires(count > 0, "Play count tidak boleh kurang dari 1");
            Debug.Assert(count < 25000000, "Play count tidak boleh lebih dari 25.000.000");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException) {
                Console.WriteLine("Error: Play count melebihi batas integer");
            }

            
        }

        public void PrintVideoDetails(){
            Console.WriteLine("ID: " + id );
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Playcount: " + playCount);

            Debug.Assert(title.Length <= 200,"Judul video terlalu panjang");
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
