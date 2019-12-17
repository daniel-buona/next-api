﻿namespace NextSI.Services.Api.Configurations
{
    public class UserAccess
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
