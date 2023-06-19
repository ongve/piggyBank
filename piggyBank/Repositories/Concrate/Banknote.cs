using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using piggyBank.Repositories.Enum;
using piggyBank.Repositories.Interface;

namespace piggyBank.Repositories.Concrate
{    
    public class Banknote : IMoney, IBanknote
    {
        private BanknoteEnum _banknotes;
        private double _value;
        private double _length;
        private double _width;
        private double _height;
        Random random = new Random();


        public BanknoteEnum BanknoteName { get => _banknotes; set => _banknotes = value; }
        public double Volume { get; set; }
        public double Value { get => _value; set => _value = value; }
        public double Length { get => _length; set => _length = value; }
        public double Width { get => _width; set => _width = value; }
        public double Height { get => _height; set => _height = value; }

        public void Fold(Banknote banknote) // Banknot para için katlama methodu.
        {
            banknote.Height = banknote.Height * 4;
            banknote.Width = banknote.Width / 4;            
        }

        public double CalculateVolume() // Atılacak paranın hacmini hesaplar.
        {
            Volume = 0;
            Volume = Width * Length * Height;           
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
