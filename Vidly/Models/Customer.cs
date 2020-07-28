using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Customer's Name")] //Data Annotation/Attribute
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribeToNewsLetter { get; set; }

        [Display(Name = "Date of Birth")]
        [LegalAgeMember]
        public DateTime? Birthdate { get; set; }

        // Navigation Property
        public MembershipType MembershipType { get; set; }

        // Foreign Key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}