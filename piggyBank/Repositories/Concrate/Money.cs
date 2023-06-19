using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using piggyBank.Repositories.Enum;
using piggyBank.Repositories.Interface;

namespace piggyBank.Repositories.Concrate
{
    public class Money
    {
        private MoneyType _moneyType;

        public MoneyType MoneyType { get => _moneyType; set => _moneyType = value; }
    }
}
