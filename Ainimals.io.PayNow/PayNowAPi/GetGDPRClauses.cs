﻿namespace Ainimals.io.PayNow.PayNowAPi;

public class GetGDPRClauses
{
    public record PayLoad
    {
        
    }

    public record Response
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Locale { get; set; }
    }
}