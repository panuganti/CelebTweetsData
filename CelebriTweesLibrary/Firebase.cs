using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CelebriTweesLibrary
{
    public class Firebase
    {
        public Firebase(): this(new FirebaseClient(new FirebaseConfig
        {
            AuthSecret = "your_firebase_secret",
            BasePath = "https://celebtweetsbeta.firebaseio.com/"
        }))
        {
        }

        private Firebase(FirebaseClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<string>> GetFeed()
        {
            var feed = await _client.GetAsync("");
            return null;
        }

        public async Task AddCelebrity(string watchlistImg, string profileImg, string bkgndImg, string name, string description)
        {

        }

        private FirebaseClient _client;
        private
    }
}
