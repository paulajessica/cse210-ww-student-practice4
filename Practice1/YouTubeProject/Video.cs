using System;
using System.Collections.Generic;

namespace Practice1.YoutubeProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Video is to get video's the title, the author, the length and the comments.
    /// </para>
    /// </summary>
    public class Video : Comment
    {
        private string _title = "";
        private string _author = "";
        private int _length = 0;// (in seconds) of the video
        List<Comment> _comments = new List<Comment>();


        /// <summary>
        /// Constructs a new instance of Video with tilte, author, length and comments list.
        /// </summary>
        public Video(string title, string author, int length, List<Comment> comments)
        {
            this._title = title;
            this._author = author;
            this._length = length;
            this._comments = comments;

        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public int GetLength()
        {
            return _length;
        }
        public List<Comment> GetComments()
        {
            return _comments;

        }
        public string SetTitle(string title)
        {
            return this._title = title;
        }
        public string SetAuthor(string author)
        {
            return this._author = author;
        }
        public int SetLength(int length)
        {
            return this._length = length;
        }

        /// <summary>
        /// Counts the number of comments in a list.
        /// </summary>
        /// <param name="comments">The list of comments.</param>
        public int NumberComments(List<Comment> comments)
        {
            this._comments = comments;
            return comments.Count();
        }

    }
}
