using System;
using Practice1.YoutubeProject;
using System.Collections.Generic;

namespace Practice1
{
    /// <summary>
    /// The program's entry point.
    /// Abstraction is an essential process to organize ideas before starting to write the code to a solution.
    /// In this project, I could abstract or internalize the concept of the program that which is to keep track 
    /// of YouTube videos and comments left on them through behaviors, characteristics, and states related to an object.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {

            //creates a videos list
            List<Video> videos = new List<Video>();

            //creates comments list to video1
            List<Comment> commentsvideo1 = new List<Comment>();
            Comment comment1 = new Comment();
            comment1.SetComment("John Steers", "This movie was WAY better than WW1984, not even close. It was so good and felt so different and grounded compared to 1984.");
            Comment comment2 = new Comment();
            comment2.SetComment("Haris Sims", "and now the world is in love with Gal Gadot.");
            Comment comment3 = new Comment();
            comment3.SetComment("Mathew Night", "This movie may have just saved the entire DC Extended Universe.");
            Comment comment4 = new Comment();
            comment4.SetComment("Fred Chris", "I'm really glad that they're making a female superhero movie finally.");
            commentsvideo1.Add(comment1);
            commentsvideo1.Add(comment2);
            commentsvideo1.Add(comment3);
            commentsvideo1.Add(comment4);

            //Creates the video1
            Video video1 = new Video("WONDER WOMAN - Official Trailer", "Warner Bros. Pictures and DC", 149, commentsvideo1);
            videos.Add(video1);

            // creates list of comments to video2
            List<Comment> commentsvideo2 = new List<Comment>();
            Comment comment5 = new Comment();
            comment5.SetComment("Ted Ford", "One day people will learn to appreciate this film.");
            Comment comment6 = new Comment();
            comment6.SetComment("Fred Sleep", "This isn't just a trailer. It's a tribute to superman himself.");
            Comment comment7 = new Comment();
            comment7.SetComment("Henry Jhonson", "This movie seems to have become better appreciated with time.");
            Comment comment8 = new Comment();
            comment8.SetComment("Padian", "In my opinion, this movie has the best Superman score of all time, gives me chills every time.");
            commentsvideo2.Add(comment5);
            commentsvideo2.Add(comment6);
            commentsvideo2.Add(comment7);
            commentsvideo2.Add(comment8);

            //Creates the video2
            Video video2 = new Video("Man of Steel - Official Trailer 3", "Warner Bros. and Legendary Pictures", 180, commentsvideo2);
            videos.Add(video2);

            // creates list of comments to video3
            List<Comment> commentsvideo3 = new List<Comment>();
            Comment comment9 = new Comment();
            comment9.SetComment("Chris Taylor", "Robert Pattinson has graduated from vampire to bat. The dude is going places.");
            Comment comment10 = new Comment();
            comment10.SetComment("Bob Kim", "To be honest. I never thought the movie would be sooo good.");
            commentsvideo3.Add(comment9);
            commentsvideo3.Add(comment10);

            //Creates the video2          
            Video video3 = new Video("THE BATMAN – Main Trailer", "Warner Bros. Pictures Presents", 157, commentsvideo3);
            videos.Add(video3);

            foreach (Video video in videos)
            {
                List<Comment> _commentslist = video.GetComments();

                Console.WriteLine($"Title: {video.GetTitle()} - Author: {video.GetAuthor()} - Length: {video.GetLength()} - Number of Comments: {video.NumberComments(_commentslist)}");

                foreach (Comment comment in _commentslist)
                {
                    Console.WriteLine($"Comment: {comment.GetComment()}");
                }

            }



        }
    }
}
