using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using CelebriTweesLibrary;

namespace CelebriTweesServer.Controllers
{
    public class FeedController : ApiController
    {
        
        public FeedController(): this(new Firebase())
        {
        }

        private FeedController(Firebase firebase)
        {
            _firebase = firebase;
        }

        // POST feed/postarticle
        [HttpPost]
        [Route("feed/postarticle")]
        public IEnumerable<string> myAction()
        {
            return new[] { "value2" };
        }

        [HttpGet]
        [Route("feed/getfeed/{request}")]
        public IEnumerable<string> GetNewsFeed(string request)
        {
            return new[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("feed/getfeed/{uid}")]
        public async Task<IEnumerable<string>> GetFeed(string uid)
        {
            return await _firebase.GetFeed();
        }

        private Firebase _firebase;
    }
}
