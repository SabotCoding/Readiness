using System;
using System.Collections.Generic;
using System.Text;

namespace Readiness.Core
{

    public class Unit
    {
        public int Id { get; set; } //Unique identifier for the unit
        public string UIC { get; set; } = string.Empty; // UIC max is 6 characters

        public string UnitName { get; set; } = string.Empty; //Common name of the unit, e.g. Dog Troop, 1st Battalion, 509th Regiment

        public Echelon Echelon { get; set; } //Echelon level of the unit, e.g. Battalion, Brigade, Division

        public string UnitType { get; set; } = string.Empty; //Type of the unit, e.g. Infantry, Armor, Artillery

        public int? ParentUnitId { get; set; }                // Saved in the DB. Null for the top unit
        public Unit? ParentUnit { get; set; }                 // Loaded by EF Core from ParentUnitId
        public List<Unit> ChildUnits { get; set; } = new();   // Filled by EF Core from each child's ParentUnitId

        public List<Soldier> Soldiers { get; set; } = new(); //// Filled in by EF Core from each UIC; never set this by hand

    }


}
