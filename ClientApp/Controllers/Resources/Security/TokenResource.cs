﻿namespace ClientApp.Controllers.Resources.Security
{
    public class AccessTokenResource
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public long Expiration { get; set; }
    }
}
