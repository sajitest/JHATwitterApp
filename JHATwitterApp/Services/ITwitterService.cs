using JHATwitterApp.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace JHATwitterApp.Services
{
    public interface ITwitterService
    {
        Task<List<Root>> GetTweetSampleStreamAsync();
    }
    public class TwitterService : ITwitterService
    {
        IConfiguration _config;
        public TwitterService(IConfiguration config)
        {
            _config = config;
        }
        public async Task<List<Root>> GetTweetSampleStreamAsync()
        {
            List<Root> elements = new List<Root>();
            TwitterCredentials credentials = new TwitterCredentials { BearerToken = _config["BearerToken"] };
            TwitterClient client = new TwitterClient(credentials);
            var sampleStreamV2 = client.StreamsV2.CreateSampleStream();

            sampleStreamV2.TweetReceived += (sender, args) =>
            {
                elements.Add(new Root { data = new Data { author_id = args.Tweet.AuthorId, created_at = args.Tweet.CreatedAt, id = args.Tweet.Id, text = args.Tweet.Text } });

                // adding a cap for stream
                if (elements.Count == 1000)
                {
                    sampleStreamV2.StopStream();
                }
            };

            await sampleStreamV2.StartAsync();

            return elements;
        }
    }
}
