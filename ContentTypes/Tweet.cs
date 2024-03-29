// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System.Collections.Generic;
using Kentico.Kontent.Delivery;

namespace CloudBoilerplateNet.Models
{
    public partial class Tweet
    {
        public const string Codename = "tweet";
        public const string TweetLinkCodename = "tweet_link";
        public const string ThemeCodename = "theme";
        public const string DisplayOptionsCodename = "display_options";

        public string TweetLink { get; set; }
        public IEnumerable<MultipleChoiceOption> Theme { get; set; }
        public IEnumerable<MultipleChoiceOption> DisplayOptions { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}