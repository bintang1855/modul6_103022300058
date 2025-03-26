using modul6_103022300058;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Review film oleh Bintang Anugrah Pratama");

        SayaTubeVideo video1 = new SayaTubeVideo("Review film Minion 1 oleh Bintang Anugrah Pratama");
        SayaTubeVideo video2 = new SayaTubeVideo("Review film Minion 2 oleh Bintang Anugrah Pratama");
        SayaTubeVideo video3 = new SayaTubeVideo("Review film Minion 3 oleh Bintang Anugrah Pratama");
        SayaTubeVideo video4 = new SayaTubeVideo("Review film SpiderMan 1 oleh Bintang Anugrah Pratama");
        SayaTubeVideo video5 = new SayaTubeVideo("Review film SpiderMan 2 oleh Bintang Anugrah Pratama");
        SayaTubeVideo video6 = new SayaTubeVideo("Review film SpiderMan Far Away oleh Bintang Anugrah Pratama");
        SayaTubeVideo video7 = new SayaTubeVideo("Review film Breaking Bad oleh Bintang Anugrah Pratama");
        SayaTubeVideo video8 = new SayaTubeVideo("Review film Narcos oleh Bintang Anugrah Pratama");
        SayaTubeVideo video9 = new SayaTubeVideo("Review film Valak 1 oleh Bintang Anugrah Pratama");
        SayaTubeVideo video10 = new SayaTubeVideo("Review film Final Destination 4 oleh Bintang Anugrah Pratama");

        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        video1.IncreasePlayCount(100);
        video2.IncreasePlayCount(200);
        video3.IncreasePlayCount(300);
        video4.IncreasePlayCount(400);
        video5.IncreasePlayCount(500);
        video6.IncreasePlayCount(600);
        video7.IncreasePlayCount(700);
        video8.IncreasePlayCount(800);
        video9.IncreasePlayCount(900);
        video10.IncreasePlayCount(1000);

        user.PrintAllVideoPlaycount();

        Console.WriteLine("Total menonton: "+ user.GetTotalVideoPlayCount());
    }
}
