﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadDemo.Models
{
    public class StoredFile
    {
        [Key]
        public Guid Id { get; set; } // identifikátor souboru a název fyzického souboru
        [ForeignKey("UploaderId")]
        public IdentityUser Uploader { get; set; } // kdo soubor nahrál
        [Required]
        public string UploaderId { get; set; } // identifikátor uživatele, který soubor nahrál
        [Required]
        public DateTime UploadedAt { get; set; } // datum a čas nahrání souboru
        [Required]
        public string OriginalName { get; set; } // původní název souboru
        [Required]
        public string ContentType { get; set; } // druh obsahu v souboru (MIME type)
        public ICollection<Thumbnail> Thumbnails { get; set; } // kolekce všech možných náhledů
    }
}
