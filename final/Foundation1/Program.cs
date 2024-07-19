using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("How to Make Enchiladas", "Marta123", 620);
        video1.AddComment("Megan", "Loved this recipe!");
        video1.AddComment("Rodolfo", "Best enchiladas ever.");
        video1.AddComment("Mia", "My family loved these! Where do you buy your cheese?");
        _videos.Add(video1);

        Video video2 = new Video("Programming in C# Tips", "TheComputerGuy", 447);
        video2.AddComment("Raul", "Thanks for the help!");
        video2.AddComment("Ara", "This helped me so much with my homework. Thank you!!");
        video2.AddComment("Sebastian", "Do you have any tips for programming in Python?");
        _videos.Add(video2);

        Video video3 = new Video("How the Book of Mormon and Bible Connect", "LilaStudies", 835);
        video3.AddComment("Milo", "Very insightful.");
        video3.AddComment("Sarah", "This helped me prepare for a lesson with the missionaries!");
        video3.AddComment("Evangeline", "You made some really good connections!");
        video3.AddComment("Veronica", "Loved this message.");
        _videos.Add(video3);
        
        Console.WriteLine();
        foreach (Video video in _videos)
        {
            video.DisplayInfo();
        }

    }
}