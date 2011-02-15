using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleLands.Blogger.Domain
{
    public class Post
    {
        public string Title {set; get; }
        public string Content {set; get;}
        public string Author {set; get;}

        public Post(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }     
    }
}
