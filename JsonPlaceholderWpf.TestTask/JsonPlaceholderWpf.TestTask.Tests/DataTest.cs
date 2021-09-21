using JsonPlaceholderWpf.TestTask.BLL;
using JsonPlaceholderWpf.TestTask.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JsonPlaceholderWpf.TestTask.Tests
{
    [TestClass]
    public class DataTest
    {
        private DataRetreiver<List<Post>> _dataService;
        private readonly string _postsServiceUrl = @"https://jsonplaceholder.typicode.com/posts";


        public DataTest()
        {
            _dataService = new DataRetreiver<List<Post>>();
        }

        [TestMethod]
        public async Task TestDataWhenOk()
        {
            var posts = await _dataService.GetPosts(_postsServiceUrl);

            Assert.IsNotNull(posts);
            Assert.AreNotEqual(posts.Count, 0);
        }
    }
}
