using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Python Tutorial", "Alice", 60);
        Video video2 = new Video("Gaming Highlights", "Bob", 30);
        Video video3 = new Video("Travel Vlog", "Charlie", 90);

        // Add comments to video1
        video1.AddComment(new Comment("Dave", "Great tutorial!"));
        video1.AddComment(new Comment("Eve", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Frank", "I love C#!"));

        // Add comments to video2
        video2.AddComment(new Comment("Grace", "Awesome gameplay!"));
        video2.AddComment(new Comment("Heidi", "Wow, that was intense!"));
        video2.AddComment(new Comment("Ivan", "Subscribe for more!"));

        // Add comments to video3
        video3.AddComment(new Comment("Judy", "Beautiful scenery!"));
        video3.AddComment(new Comment("Karl", "I want to visit there!"));
        video3.AddComment(new Comment("Leo", "Nice vlog!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display loop for video info and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} minutes");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment._author} : {comment._text}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
    
}