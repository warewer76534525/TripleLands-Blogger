using System;
using TripleLands.Blogger.Domain;
using TripleLands.Blogger.Dao;
using System.Collections.Generic;

namespace TripleLands.Blogger.ServiceImpl
{
    public class BlogService : IBlogService
    {
        IPostDao postDao;

        public void Post(Post post)
        {
            postDao.Save(post);
        }

        public IPostDao PostDao {
            set { postDao = value; }
        }


        public List<Post> GetRecentPost()
        {
            return null;
        }
    }
}
