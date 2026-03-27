using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Bake Cookies", "Sarah Lee", 420);
        video1.AddComment(new Comment("Emma", "This recipe was easy to follow."));
        video1.AddComment(new Comment("Noah", "The cookies turned out great."));
        video1.AddComment(new Comment("Liam", "Thanks for sharing this."));
        videos.Add(video1);

        Video video2 = new Video("Morning Workout Routine", "Jake Fitness", 600);
        video2.AddComment(new Comment("Olivia", "I tried this workout today."));
        video2.AddComment(new Comment("Ava", "This was very helpful."));
        video2.AddComment(new Comment("Mason", "I liked the exercises."));
        videos.Add(video2);

        Video video3 = new Video("Beginner Guitar Lesson", "Music Mike", 900);
        video3.AddComment(new Comment("Sophia", "This helped me learn faster."));
        video3.AddComment(new Comment("James", "Great lesson for beginners."));
        video3.AddComment(new Comment("Isabella", "Please make more videos like this."));
        videos.Add(video3);

        Video video4 = new Video("Travel Guide to New York", "Travel Time", 720);
        video4.AddComment(new Comment("Lucas", "I want to visit now."));
        video4.AddComment(new Comment("Mia", "The tips were useful."));
        video4.AddComment(new Comment("Ethan", "This video was fun to watch."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetName() + ": " + comment.GetText());
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
}