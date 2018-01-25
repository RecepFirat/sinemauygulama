using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinemauygulama
{
    class Seans
    {
        public Seans()
        {
            Salonlar = new List<Salon>();
        }
        public TimeSpan BaslamaSaati { get; set; }
        public TimeSpan BitisSaati { get; set; }
        public List<Salon> Salonlar { get; set; }


    }
}
