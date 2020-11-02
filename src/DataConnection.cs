using System;
using System.Collections.Generic;
using System.Text;

namespace ADALotto.Models
{
    public class DataConnection<T>
    {
        public IEnumerable<T>? Nodes { get; set; }
        public int? TotalCount { get; set; }
    }
}
