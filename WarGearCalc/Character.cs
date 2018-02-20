using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGearCalc
{
    class Character
    {
        public String Name { get; set; }
        public String Career { get; set; }
        public Equipment Head { get; set; }
        public Equipment Chest { get; set; }

        public Character(String career)
        {
            Career = career;
        }
    }
}
