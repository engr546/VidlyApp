using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public int? Id { get; set; }

        [Required] //Data Annotation/Attribute
        [StringLength(255)]
        public string Name { get; set; }

        // Foreign Key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [LegalAgeMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribeToNewsLetter { get; set; }

        public string Title
        {
            get
            {
                return Id != null && Id != 0 ? "Edit Customer" : "New Customer";
            }
        }

        public CustomerFormViewModel()
        {
            Id = 0;
        }

        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            MembershipTypeId = customer.MembershipTypeId;
            Birthdate = customer.Birthdate;
            IsSubscribeToNewsLetter = customer.IsSubscribeToNewsLetter;
        }

    }
}