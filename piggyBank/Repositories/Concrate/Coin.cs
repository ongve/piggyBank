using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using piggyBank.Repositories.Enum;
using piggyBank.Repositories.Interface;

namespace piggyBank.Repositories.Concrate 
{
    public class Coin : IMoney, ICoin
    {
        private CoinEnum _coine;
        private double _value;
        private double _radius;
        private double _pi;
        private double _height;
        Random random = new Random();

        public CoinEnum CoinName { get => _coine; set => _coine = value; }
        public double Volume { get; set; }
        public double Value { get => _value; set => _value = value; }
        public double Radius { get => _radius; set => _radius = value; }
        public double Pi { get => _pi; set => _pi = value; }
        public double Height { get => _height; set => _height = value; }

        public double CalculateVolume() // Atılacak paranın hacmi ve atıldıktan sonra meydana gelecek ekstra boşluk (rastgele) hacmi  hesaplar.
        {
            Volume = 0;
            Volume = Pi * Math.Pow(Radius, 2);

            return Volume;
        }
        // Para hacminin %25-%75 arasında rastgele kumbarada meydana gelecek boşluk hacminin hesaplanması.
        public double CalculateExcessVolume()
        {
            double excessVolume = Convert.ToDouble(random.Next(25, 75) / 100) * Volume;

            return excessVolume;
        }
    }
}
