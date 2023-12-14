using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Abstraction", "Peter", 25);
        video1.AddComment("Adam","Nice video");
        video1.AddComment("Eve","Very helpful");
        video1.AddComment("Noe","I learned a lot");
        videos.Add(video1);

        Video video2 = new Video("Encapsulation", "James", 43);
        video2.AddComment("Samuel","Good job");
        video2.AddComment("David","Need more help");
        video2.AddComment("Saul","Keep going");
        video2.AddComment("Jonathan","Keep it up");
        videos.Add(video2);

        Video video3 = new Video("Inheritance", "John", 55);
        video3.AddComment("Mathew","Complex topic");
        video3.AddComment("Luke","Need more detail");
        video3.AddComment("Mark","Did not get it");
        video3.AddComment("Paul","Very difficult");
        video3.AddComment("Tito","Need to study more");
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Video title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }        
    }
}