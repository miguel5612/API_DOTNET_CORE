﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace jwt.Models.DTO
{
    public class User
    {
        [Key]
        public int Id_user { get; set; }
                
        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public string GUID { get; set; }

        [MaxLength(50)]
        public string Role { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Updated { get; set; }

        [Required]
        public int Id_state { get; set; }
    }
}
