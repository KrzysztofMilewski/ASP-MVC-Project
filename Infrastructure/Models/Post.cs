﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class Post
    {
        public int Id { get; private set; }

        [Required]
        [StringLength(40)]
        public string Title { get; set; }

        [Required]
        public string Contents { get; set; }

        [Required]
        public DateTime DatePublished { get; set; }

        public ApplicationUser Publisher { get; set; }

        [Required]
        public string PublisherId { get; set; }

        public DateTime? LastTimeEdited { get; set; }

        public int NumberOfEdits { get; set; }

        public bool PubliclyVisible { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}