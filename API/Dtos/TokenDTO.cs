﻿namespace API.Dtos
{
    public class TokenDTO
    {
        public UserDTO User { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
