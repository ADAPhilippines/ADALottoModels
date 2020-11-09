using System;
using System.Collections.Generic;
using System.Text;

namespace ADALotto.Models
{
    public class Block
    {
        public long? Id { get; set; }
        public long? BlockNo { get; set; }
        public long? EpochNo { get; set; }
        public long? Size { get; set; }
        public DateTime? Time { get; set; }
        public int[]? Hash { get; set; }
    }
}
