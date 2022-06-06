using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trader.Models
{
    public class AssetTransection : DomainObject
    {
        public int Id { get; set; }
        public Acount Acount { get; set; }
        public bool IsPurchase { get; set; }
        public Stock Stock { get; set; }
        public int ShareAmount { get; set; }
        public DateTime DateProcessed { get; set; }
    }
}
