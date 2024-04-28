using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopCMS.Models
{
    public class UserProfile
    {
        [Key]
        [ForeignKey("OnlineShopUser")]
        public string UserId { get; set; } 

       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; } 
        public string Gender { get; set; } 

     
        public string Email { get; set; } 
        public string PhoneNumber { get; set; }

      
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

      
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; } 

       
        public virtual IdentityUser User { get; set; }
    }
}