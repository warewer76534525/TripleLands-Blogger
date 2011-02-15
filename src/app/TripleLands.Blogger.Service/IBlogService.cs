using TripleLands.Blogger.Domain;
using System.Collections.Generic;

namespace TripleLands.Blogger.ServiceImpl
{
    public interface IBlogService
    {
        void Post(Post post);

        List<Post> GetRecentPost();
    }
}
