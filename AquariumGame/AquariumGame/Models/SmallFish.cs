using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumGame.Models
{
    [Serializable]

    class SmallFish : Fish // Маленька рибка. Нічого не їсть.
    {
        public SmallFish()
        {
            IsSatisfied = 0;
        }
    }
}
