/*
 * ITSE 1430
 * Daniel Clement
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactManager
{
    public class Message : IValidatableObject
    {
        private string _composeMessage = "";

        private string _emailAddress = "";

        private string _name = "";

        private string _subject = "";

        public string ComposeMessage
        {
            get => _composeMessage ?? "";
            set => _composeMessage = value;
        }

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

        public string Subject
        {
            get => _subject ?? "";
            set => _subject = value;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Subject))
                yield return new ValidationResult("Subject is required.", new[] { nameof(Subject) });
        }
    }
}