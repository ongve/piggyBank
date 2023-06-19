using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using piggyBank.Repositories.Concrate;


namespace piggyBank.Repositories.Interface
{
    public interface ICoin
    {
        double Radius { get; set; }
        double Pi { get; set; }
        double Height { get; set; }
    }
}
