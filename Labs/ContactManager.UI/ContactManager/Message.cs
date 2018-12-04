using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Message : IValidatableObject
    {
        public string Name
        {
            get => _name ?? "";
            set => _name = value;
        }
        private string _name = "";

        public string EmailAddress
        {
            get => _emailAddress ?? "";
            set => _emailAddress = value;
        }
        private string _emailAddress = "";

        public string Subject
        {
            get => _subject ?? "";
            set => _subject = value;
        }
        private string _subject = "";

        public string ComposeMessage
        {
            get => _composeMessage ?? "";
            set => _composeMessage = value;
        }
        private string _composeMessage = "";

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {

            //if (String.IsNullOrEmpty(Name))
            //    yield return new ValidationResult("Name is required.",
            //                    new[] { nameof(Name) });

            //if (String.IsNullOrEmpty(EmailAddress))
            //    yield return new ValidationResult("Email Address is required.",
            //                    new[] { nameof(EmailAddress) });

            if (String.IsNullOrEmpty(Subject))
                yield return new ValidationResult("Subject is required.",
                                new[] { nameof(Subject) });
        }
    }
}
