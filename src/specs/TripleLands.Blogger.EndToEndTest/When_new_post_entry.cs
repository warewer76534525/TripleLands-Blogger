using NUnit.Framework;
using TripleLands.Blogger.Domain;
using TripleLands.Blogger.Service;

namespace TripleLands.Blogger.EndToEndTest
{
    [TestFixture]
    class When_new_post_entry
    {
        [Test]
        public void Should_display_in_recents_entry() {
            Post post = new Post("title", "content", "author");
            IBlogService blogService = new BlogService();
            blogService.Post(post);

            Assert.AreEqual(post, blogService.GetRecentPost());
        }
    }
}
