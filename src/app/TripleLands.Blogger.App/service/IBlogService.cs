using System.Collections.Generic;
using TripleLands.Blogger.Domain;

namespace TripleLands.Blogger.Service
{
    public interface IBlogService
    {
        void Post(Domain.Post post);

        IList<Post> GetRecentPost();
    }
}
