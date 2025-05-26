using System;


// Write a program to keep track of YouTube videos and comments left on them
// Video information and comments
class Program
{
    static void Main(string[] args)
    {
        // creating video objects
        Video video1 = new Video("Constructors | C# | Tutorial 26", "Giraffe Academy", 628);
        Video video2 = new Video("C# abstract classes👻", "Bro Code", 156);
        Video video3 = new Video("Encapsulation in C#", "NET Programmer", 152);

        // adding comments to videos
        video1.AddComment("Pat", "I love the way you break things down for a beginner. Thanks!");
        video1.AddComment("Aba", "Nice tutorial, it cleared up a lot of confusion I had.");
        video1.AddComment("Oscar", "Love it! I would love examples that a little more advanced!");

        video2.AddComment("Alexander", "Brief, short, clear, concise, perfect!");
        video2.AddComment("Glenn", "Just straight up brilliant. Just learnt abstraction in under 3 minutes.");
        video2.AddComment("Israel", "well explained, thanks!");

        video3.AddComment("Paula", "Thanks for sharing.");
        video3.AddComment("Kuzco", "so good thank you!");
        video3.AddComment("Eduard", "Thanks.");

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length (in seconds): " + video.GetLength());
            Console.WriteLine("Comments: ");

            // "appending" comments to videos
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}