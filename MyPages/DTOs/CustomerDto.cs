using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyPages.Models;

namespace MyPages.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        //we should exclude this, because this will create dependency to our domain model.
        //public MemberShipType MemberShipType { get; set; }

        public byte MemberShipTypeId { get; set; }
        
        // [Min18YearsIfAMember]
        // We need comment above annotation because it will get an exception
        // Because we casting the object instance to 'Customer' in this ValidationAttribute.
        // If we use this Validation to 'CustomerDto', we get exceptions.
        // Ideally, we should only have one way to deal with creating customers,
        // Currently, we have two end points. One is the api End-Point we just created, 
        // another one is normal MVC action being created in 'Building Form Branch'.
        // If we need only api appoach to create customer, we should drop all MVC actions and modify our forms to post api End-point.
        // Since this project is only for practice, I just keep the application as is.

        public DateTime? Birthdate { get; set; }
    }
}