using System;
using System.Collections.Generic;


namespace modul6_103022300058
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVIdeos;
        public string Username;

        public SayaTubeUser(string Username) {
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
            uploadedVIdeos.Add(video);
        }

        public void PrintAllVideoPlaycount() {
            Console.WriteLine("User: " + Username);

            for (int i = 0; i < uploadedVIdeos.Count; i++) {
                Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVIdeos[i].GetTitle() );
            }
        }
    }
}
