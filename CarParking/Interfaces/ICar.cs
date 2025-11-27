using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    interface ICar
    {
        string Name { get; set; }
        int Tank—ondition { get; set; }
        string Launch {  get; set; }
        bool CanRefill { get; set; }

        void CarLaunch(ICar Car);
    }
}
