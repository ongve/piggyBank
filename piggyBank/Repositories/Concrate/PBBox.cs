using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using piggyBank.Repositories.Enum;
using piggyBank.Repositories.Interface;

namespace piggyBank.Repositories.Concrate
{
    public class PBBox : IPBBox
    {
        private List<string> _totalMoneyList;
        private double _totalMoney;
        public List<string> totalMoneyList { get => _totalMoneyList; set => _totalMoneyList = value; }
        public double Volume { get; set; }
        public double totalMoney { get => _totalMoney; set => _totalMoney = value; }

        public double ShakeIt(double Volume)
        {
            double NewExcessVolume = Volume * 0.25;
            double NewVolume = Volume + NewExcessVolume;

            return NewVolume;
        }

        public void FixIt()
        {
            Volume = 0;
            totalMoney = 0;
            totalMoneyList.Clear();
        }
    }
}
