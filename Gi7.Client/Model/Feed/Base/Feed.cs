﻿using System;
using System.Xml.Serialization;

namespace Gi7.Client.Model.Feed.Base
{
    [XmlInclude(typeof (IssueCommentFeed)), XmlInclude(typeof (CommitCommentFeed)), XmlInclude(typeof (PullRequestFeed)), XmlInclude(typeof (IssueFeed)), XmlInclude(typeof (PushFeed)), XmlInclude(typeof (CreateFeed)), XmlInclude(typeof (WatchFeed)), XmlInclude(typeof (DeleteFeed)), XmlInclude(typeof (FollowFeed)), XmlInclude(typeof (ForkFeed))]
    public class Feed
    {
        public User User { get; set; }

        public DateTime CreatedAt { get; set; }

        public String Actor { get; set; }

        public String Url { get; set; }

        public bool Public { get; set; }

        public virtual String Template
        {
            get { return "did a non supported action at"; }
        }

        public virtual String Image
        {
            get { return null; }
        }

        public String DestinationFormat { get; set; }

        public virtual String Destination
        {
            get { return String.Format(DestinationFormat, Actor); }
        }
    }
}