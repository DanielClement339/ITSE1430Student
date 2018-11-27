/*
 * ITSE 1430
 * Daniel Clement
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactManager
{
    public class Contact : IValidatableObject
    {
        private string _emailAddress = "";

        private string _name = "";

        public string EmailAddress
        {
            get => _emailAddress ?? "";
            set => _emailAddress = value;
        }

        public string Name
        {
            get => _name ?? "";
            set => _name = value;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name is required.", new[] { nameof(Name) });

            if (String.IsNullOrEmpty(EmailAddress))
                yield return new ValidationResult("Email Address is required.", new[] { nameof(EmailAddress) });
        }
    }
}