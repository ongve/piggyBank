using piggyBank.Repositories.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggyBank.Repositories.Interface
{
    public interface IBanknote
    {
        double Length { get; set; }
        double Width { get; set; }
        double Height { get; set; }
        void Fold(Banknote banknote);
    }
}
