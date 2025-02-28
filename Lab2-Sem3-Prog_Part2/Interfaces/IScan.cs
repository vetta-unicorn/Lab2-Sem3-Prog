using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface IScan
    {
        bool ifWireless { get; set; }

        ColorModels colorModel { get; set; }

    }
}
