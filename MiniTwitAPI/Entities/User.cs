﻿using System.ComponentModel.DataAnnotations;

namespace MiniTwitAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public bool IsPasswordHashed { get; set; } = true;
    }
}
