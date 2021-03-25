﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Books
{
    public class CreateUpdateBookDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
