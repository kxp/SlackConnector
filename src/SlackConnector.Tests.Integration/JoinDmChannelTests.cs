﻿using NUnit.Framework;
using SlackConnector.Tests.Integration.Configuration;

namespace SlackConnector.Tests.Integration
{
    [TestFixture]
    public class JoinDmChannelTests
    {
        [Test]
        public void should_join_channel()
        {
            // given
            var config = new ConfigReader().GetConfig();

            ISlackConnector slackConnector = new SlackConnector();
            slackConnector.Connect(config.Slack.ApiToken).Wait();

            // when
            var result = slackConnector.JoinDirectMessageChannel(config.Slack.TestUserId).Result;

            // then
            Assert.That(result, Is.Not.Null);
        }
    }
}