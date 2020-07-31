﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[LegalAgeMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribeToNewsLetter { get; set; }

        // Foreign Key
        public byte MembershipTypeId { get; set; }
    }
}