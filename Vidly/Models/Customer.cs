﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] //Data Annotation/Attribute
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribeToNewsLetter { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
        // Navigation Property
        public MembershipType MembershipType { get; set; }
        // Foreign Key
        public byte MembershipTypeId { get; set; }
    }
}