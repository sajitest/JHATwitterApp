using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JHATwitterApp.Services;
using JHATwitterApp.Models;
using System.Text.RegularExpressions;

namespace JHATwitterApp.Controllers
{
    public class TwitterController : Controller
    {
        private IConfiguration _config;
        private ITwitterService _twitterService;
        public TwitterController(IConfiguration config, ITwitterService twitterService)
        {
            _config = config;
            _twitterService = twitterService;
        }
        public async Task<IActionResult> Index()
        {

            List<Root> elements = new List<Root>();
            elements = await _twitterService.GetTweetSampleStreamAsync();
            ViewData["TweetCount"] = elements.Count;

            // perent of url 
            decimal urlCount = (from element in elements
                                where element.data.text.Contains("https://")
                                select element).Count();
            decimal urlPercent = (urlCount / elements.Count) * 100;
            ViewData["UrlPercent"] = Math.Round(urlPercent, 2);

            //percent of image url 
            decimal picurlCount = (from element in elements
                                   where element.data.text.Contains("https://t.co/")
                                   select element).Count();
            decimal picurlCountPercent = (picurlCount / elements.Count) * 100;
            ViewData["PicUrlPercent"] = Math.Round(picurlCountPercent, 2);

            Regex hashtag = new Regex(@"#\w+");

            var hashValues = from element in elements
                             let matches = hashtag.Matches(element.data.text)
                             where matches.Count > 0
                             select new
                             {
                                 matchedValues = from match in matches
                                                 select match.Value
                             };


            ViewData["HashCount"] = hashValues.Count();

            Regex emoji = new Regex(@"(\u00a9|\u00ae|[\u2000-\u3300]|\ud83c[\ud000-\udfff]|\ud83d[\ud000-\udfff]|\ud83e[\ud000-\udfff])");

            var emojiValues = from element in elements
                              let matches = emoji.Matches(element.data.text)
                              where matches.Count > 0
                              select new
                              {
                                  matchedValues = from match in matches
                                                  select match.Value
                              };

            ViewData["EmojiCount"] = emojiValues.Count();


            return View();
        }
    }
}
