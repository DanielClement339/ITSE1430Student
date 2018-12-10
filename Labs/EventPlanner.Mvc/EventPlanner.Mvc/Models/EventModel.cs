using System;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Mvc.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DateRangeAttributeAttribute : ValidationAttribute
    {
        public bool ValidateEndDate { get; set; }
        public bool ValidateStartDate { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = validationContext.ObjectInstance as EventModel;

            if (model != null)
            {
                if (model.StartDate > model.EndDate && ValidateEndDate)
                {
                    return new ValidationResult(string.Empty);
                }
            }

            return ValidationResult.Success;
        }
    }

    public class EventModel
    {
        public EventModel()
        {
        }

        public EventModel(EventPlanner.ScheduledEvent item)
        {
            if (item != null)
            {
                Id = item.Id;
                Name = item.Name;
                Description = item.Description;
                StartDate = item.StartDate;
                EndDate = item.EndDate;
                IsPublic = item.IsPublic;
            };
        }

        public ScheduledEvent ToDomain()
        {
            return new ScheduledEvent()
            {
                Id = Id,
                Name = Name,
                Description = Description,
                StartDate = StartDate,
                EndDate = EndDate,
                IsPublic = IsPublic
            };
        }

        public string Description { get; set; }

        [Display(Name = "End Date")]
        [DateRangeAttribute(ValidateEndDate = true, ErrorMessage = "The End Date must come after the start date")]
        public DateTime EndDate { get; set; }

        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        public bool IsPublic { get; set; }
    }
}