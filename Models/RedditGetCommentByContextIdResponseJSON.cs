﻿namespace _01152023_Reddit_ScreenshotGifBot.Models
{
    public class RedditGetCommentByContextIdResponseJSON
    {
        public string? kind { get; set; }
        public Data? data { get; set; }

        public class Data
        {
            public Child[]? children { get; set; }
        }

        public class Child
        {
            public string? kind { get; set; }
            public Data1? data { get; set; }
        }

        public class Data1
        {
            public string? subreddit { get; set; }
            public string? id { get; set; }
            public string? parent_id { get; set; }
            public string? body { get; set; }
            public string? name { get; set; }
            public string? body_html { get; set; }
        }
    }
}