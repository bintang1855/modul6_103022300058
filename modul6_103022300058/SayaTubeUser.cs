using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;


namespace modul6_103022300058
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVIdeos;
        public string Username;

        public SayaTubeUser(string Username) {
            Contract.Requires(Username != null, "Username tidak boleh kosong");
            Contract.Requires(Username.Length <= 100, "Username tidak boleh lebih dari 200 karakter");
            Random random = new Random();

            this.id = random.Next(10000, 99999);
            this.Username = Username;
            this.uploadedVIdeos = new List<SayaTubeVideo>();
        }
        
        public int GetTotalVideoPlayCount() {
            int totalPlayCount = 0;
            foreach (var video in uploadedVIdeos) {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Contract.Requires(video != null,"video tidak boleh null");
            Contract.Requires(video.GetPlayCount() < int.MaxValue,"Play count harus kurang dari integer max");
            uploadedVIdeos.Add(video);
        }

        public void PrintAllVideoPlaycount() {
            Console.WriteLine("User: " + Username);

            Contract.Ensures(uploadedVIdeos.Count <= 8,"Jumlah video yang ditampilkan max 8");

            for (int i = 0; i < Math.Min(uploadedVIdeos.Count,8); i++) {
                Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVIdeos[i].GetTitle() );
            }
        }
    }
}
