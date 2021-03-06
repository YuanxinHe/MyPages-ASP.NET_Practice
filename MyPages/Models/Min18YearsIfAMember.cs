﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPages.Models
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // In customer class, we associated this validation with dateOfBirth,
            // in this case, the validationContext should be customer 
            var customer = (Customer) validationContext.ObjectInstance;
            if (customer.MemberShipTypeId==0 || customer.MemberShipTypeId == 1)
                return ValidationResult.Success;
            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required");
            }


            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on a membership"));

        }
    }
}