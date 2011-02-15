using NUnit.Framework;
using TripleLands.Blogger.Domain;
using TripleLands.Blogger.Service;
using Spring.Context.Support;
using Spring.Context;

namespace TripleLands.Blogger.EndToEndTest
{
    [TestFixture]
    class When_new_post_entry
    {
        IApplicationContext context;
        IBlogService blogService;

        [SetUp]
        public void SetUp() {
            context = ContextRegistry.GetContext();
            blogService = (IBlogService) context.GetObject("BlogService");
        }

        [Test]
        public void Should_display_in_recents_entry() {
            Post post = new Post("title", "content", "author");
            blogService.Post(post);

            Assert.AreEqual(post, blogService.GetRecentPost());
        }
    }
}
