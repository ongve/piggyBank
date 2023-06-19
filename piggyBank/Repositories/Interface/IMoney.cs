using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggyBank.Repositories.Interface
{
    public interface IMoney
    {
        double Value { get; set; }
        double Volume { get; set; }
        double CalculateVolume();
        double CalculateExcessVolume();
    }
}
