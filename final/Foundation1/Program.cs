using System;
using System.Collections.Generic;

namespace Foundation1 {
    class Program
    {
        static void Main(string[] args)
        {
            List<Comment> comments1 = new List<Comment>{new Comment("Jeff Makis", "Good video"), new Comment("Hannah Davies", "Loved it!"), new Comment("Jon Tunks", "eh....")};
            List<Comment> comments2 = new List<Comment>{new Comment("Dan Wens", "Not a huge fan of this one..."), new Comment("George Tynes", "Best one yet."), new Comment("Ben Nguyen", "Very helpful")};
            List<Comment> comments3 = new List<Comment>{new Comment("Harry Metzgar", "Decent quality"), new Comment("Avery Smither", "Meh"), new Comment("Weston Topps", "Pretty good.")};

            Video video1 = new Video("First Video", "John Smith", 300, comments1);
            Video video2 = new Video("How to...", "Smith Peart", 600, comments2);
            Video video3 = new Video("Building a house", "Saul McConnell", 450, comments3);

            List<Video> videos = new List<Video>{video1, video2, video3};

            foreach (Video video in videos) {
                Console.WriteLine(video.GetInfo());
                video.DisplayComments();
            }
        }
    }
}