using System;
using System.Collections.Generic;

namespace Foundation1 {

    public class Video {

        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments;

        public Video(string title, string author, int length, List<Comment> comments) {
            _title = title;
            _author = author;
            _length = length;
            _comments = comments;
        }

        public string GetInfo() {
            return $"Title: {_title}\nAuthor: {_author}\nLength: {_length}\nNumber of Comments: {_comments.Count}\n";
        }

        public void DisplayComments() {
            foreach (Comment comment in _comments) {
                Console.WriteLine(comment.GetCommentInfo());
            }
        }
    }
}