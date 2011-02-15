using TripleLands.Blogger.Domain;

namespace TripleLands.Blogger.Service
{
    public interface IBlogService
    {
        void Post(Post post);

        object GetRecentPost();
    }
}
