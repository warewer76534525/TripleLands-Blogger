using System;
using TripleLands.Blogger.Domain;
using TripleLands.Blogger.Dao;

namespace TripleLands.Blogger.Service
{
    public class BlogService : IBlogService
    {
        IPostDao postDao;

        public void Post(Post post)
        {
            postDao.Save(post);
        }


        public object GetRecentPost()
        {
            throw new NotImplementedException();
        }
    }
}
