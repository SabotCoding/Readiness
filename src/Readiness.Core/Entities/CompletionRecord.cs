using System;
using System.Collections.Generic;
using System.Text;

namespace Readiness.Core.Entities
{
    public class CompletionRecord
    {
        public int Id { get; set; } // Unique identifier for the completion record

        public Soldier Soldier { get; set; } = null!; // The soldier associated with the completion record

        public int SoldierId { get; set; } // The ID of the soldier associated with the completion record

        public RequirementType RequirementType { get; set; } = null!; // The requirement type associated with the completion record

        public int RequirementTypeId { get; set; } // The ID of the requirement type associated with the completion record

        public DateOnly CompletedOn { get; set; } // The date the requirement was completed

    }
}
