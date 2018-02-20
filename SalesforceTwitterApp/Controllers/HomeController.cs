using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TweetSharp;
using SalesforceTwitterApp.Constants;

namespace SalesforceTwitterApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return TwitterCallback();
        }

        public ActionResult TwitterCallback()
        {
            List<TwitterStatus> lstsftweets = new List<TwitterStatus>();
          
            try
            {
                TwitterService service = new TwitterService();               
                service.AuthenticateWith(AppConstants.key, AppConstants.secret, AppConstants.token, AppConstants.tokesecret);
                VerifyCredentialsOptions options = new VerifyCredentialsOptions();
                TwitterUser user = service.VerifyCredentials(options);
                
                IEnumerable<TwitterStatus> tweets = service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions { ScreenName = AppConstants.screenName, Count = AppConstants.noofTweets });
                
                ViewBag.Tweets = tweets;

                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}