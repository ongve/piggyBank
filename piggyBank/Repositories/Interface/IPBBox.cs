using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggyBank.Repositories.Interface
{
    public interface IPBBox
    {
        double Volume { get; set; }
        List<string> totalMoneyList { get; set; }
        double totalMoney { get; set; }
        double ShakeIt(double Volume);
        void FixIt();
    }
}
