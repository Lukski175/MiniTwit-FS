﻿using System.Text.Json.Serialization;

namespace MiniTwitClient.Models
{
    public class RegisterRequest
    {
        public string Username { get; set; }
        public string Email { get; set; }
        [JsonPropertyName("pwd")] public string Password { get; set; }
    }
}
