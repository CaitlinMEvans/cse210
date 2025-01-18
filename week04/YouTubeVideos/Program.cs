// Creativity Add: Added a like/dislike option to the comment section.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Caitlin's YouTube Video Program\n");

        // Create video objects
        var video1 = new Video("3D Printing Tutorials", "3DWorld", 600);
        var video2 = new Video("Meats and Seasoning 101", "MeatSmokeKing", 900);
        var video3 = new Video("2025 Scrapbook Layout Ideas", "ScrapbookingQueen", 1200);

        // Add comments to video1
        video1.AddComment(new Comment("Caitlin", "This video was amazing! Great Job!", 15, 2));
        video1.AddComment(new Comment("Marie", "I loved the visuals you used in this video - so professional!", 20, 1));
        video1.AddComment(new Comment("Evans", "Great tutorial it was very informative. Thanks!", 25, 0));

        // Add comments to video2
        video2.AddComment(new Comment("Anthony", "Your recipe was very easy to follow. Tasted FANTASTIC!", 30, 5));
        video2.AddComment(new Comment("Chancellor", "Made your chicken wing spice - So good!", 18, 2));
        video2.AddComment(new Comment("Ace", "Can you do a video on smoking a prime rib?", 10, 3));

        // Add comments to video3
        video3.AddComment(new Comment("Amanda", "These tips really helped me improve my scrapbooking layouts.", 12, 1));
        video3.AddComment(new Comment("Lynn", "The alcohol ink tutorial was very easy to follow!", 22, 2));
        video3.AddComment(new Comment("Riley", "Looking forward to your next diamond painting!", 16, 0));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display each video's details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}