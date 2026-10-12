using System;
using System.Collections.Generic;
using System.Text;

namespace Readiness.Core
{
    public class RequirementType
    {
        public int Id { get; set; } // Unique identifier for the requirement type

        public string Name { get; set; } = string.Empty; // Name of the requirement type, e.g. "Dental", "PHA

        public int IntervalMonths { get; set; } // Interval in months for the requirement type, e.g. 12 for annual requirements

        public List <CompletionRecord> CompletionRecords { get; set; } = new(); // List of completion records for the requirement type
    }
}
