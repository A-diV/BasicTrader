using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trader.Models
{
    public class Acount : DomainObject
    {
        public int Id { get; set; }
        public string User { get; set; }
        public User AccountHolder { get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssetTransection> AssetTransactions { get; set; }
    }
}
