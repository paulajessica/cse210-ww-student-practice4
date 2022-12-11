using System;

namespace Practice1.YoutubeProject
{
    /// <summary>
    /// <para>
    /// The responsibility of Comment is to get comment's the name and the text .
    /// </para>
    /// </summary>
    public class Comment
    {
        private string _name = "";
        private string _comment = "";

        /// <summary>
        /// Constructs a new instance of Comment.
        /// </summary>
        public Comment()
        {

        }
        public string GetPersonComment()
        {
            return _name;
        }
        public string GetComment()
        {
            return _comment;
        }
        public void SetPersonComment(string name)
        {
            this._name = name;
        }
        public void SetComment(string name, string comment)
        {
            this._name = name;
            this._comment = comment;
        }


    }

}