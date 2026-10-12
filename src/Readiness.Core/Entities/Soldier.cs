using System;
using System.Collections.Generic;
using System.Text;

namespace Readiness.Core.Entities
{
    public class Soldier
    {
        public int Id { get; set; } // Unique identifier for the soldier

        public string FirstName { get; set; } = string.Empty; // Soldier's first name

        public string LastName { get; set; } = string.Empty; // Soldier's last name

        public string DodId { get; set; } = string.Empty; // Soldier's Department of Defense ID

        public string Rank { get; set; } = string.Empty; // Soldier's rank, e.g. Private, Sergeant, Captain

        public string MOS { get; set; } = string.Empty; // Soldier's Military Occupational Specialty

        public int UnitId { get; set; } // Unique identifier for the soldier's unit

         public Unit Unit { get; set; } = null!;

        public List<CompletionRecord> CompletionRecords { get; set; } = new(); // List of completion records for the soldier

    }
}