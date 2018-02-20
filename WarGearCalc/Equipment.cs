using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGearCalc
{
    class Equipment
    {
        // Generic attributes
        public String Name { get; set; }
        public Slot EqSlot { get; set; }
        public Type EqType { get; set; }
        public int SetId { get; set; }
        public String Source { get; set; }

        // Stats
        int BallisticSkill { get; set; }
        int Initiative { get; set; }
        int Intelligence { get; set; }
        int Strength { get; set; }
        int Toughness { get; set; }
        int WeaponSkill { get; set; }
        int Willpower { get; set; }
        int Wounds { get; set; }

        // Defense
        int Armor { get; set; }
        int CorporealResist { get; set; }
        int ElementalResist { get; set; }
        int SpiritResist { get; set; }

        // Defense Adv.
        int ArmorPenaltyReduction { get; set; }
        int Block { get; set; }
        int Crit_Reduction { get; set; }
        int Distrupt { get; set; }
        int Dodge { get; set; }
        int Parry { get; set; }

        // Offense
        int Attack_Speed { get; set; }
        int Heal_Power { get; set; }
        int Magic_Power { get; set; }
        int Melee_Power { get; set; }
        int Ranaged_Power { get; set; }

        // Crit
        int Heal_Crit { get; set; }
        int Magic_Crit { get; set; }
        int Melee_Crit { get; set; }
        int Ranged_Crit { get; set; }

        // Strikethrough
        int Block_Strikethrough { get; set; }
        int Distrupt_Strikethrough { get; set; }
        int Dodge_Strikethrough { get; set; }
        int Parry_Strikethrough { get; set; }

        // Regen
        int AP_Regen { get; set; }
        int HP_Regen { get; set; }
        int Morale_Regen { get; set; }

        // TODO: add all slots/types here
        public enum Slot { Head, Chest };
        public enum Type { Cloth, Heavy };
    }
}
