using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesforceTwitterApp.Constants
{
    /*
    Salesforce Twitter Application
    The Contants class can be used to maintain all the hardcoded values or properties in one place, So the application be configurable.
    This can be replaced with a properrty file for better management; This is used for convinience on this project.
    We may add more functionalities on this bean for different properties like DB connection or webservice URL's.

    @author  Kishtaiah R
    @version 1.0
    @since   2018/2/18
    */

    static class AppConstants
    {
        public const string key = "Hrl41AUnebDgQPOYHjxtqfs4P";
        public const string secret = "b2gObCgHieepmU0QJJHgeKmeYXSc0dy85ygn6BMrppUk1msVoc";
        public const string token = "964333064620003328-hllBxAcjv4Cigey1H9q3XEKjbSLSGe1";
        public const string tokesecret = "HZAbouAICZZfzNl09dsDB36KKhVwePaGjsW3o4ZARSqXk";
        public const string screenName = "@salesforce";
        public const int noofTweets = 10;
    }
}