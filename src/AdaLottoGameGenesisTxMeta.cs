using System;
using System.Collections.Generic;
using System.Text;

namespace ADALotto.Models
{
    public class AdaLottoGameGenesisTxMeta
    {
        public float Id { get; set; }
        public int Type { get; set; }
        public float Prize { get; set; }
        public int Digits { get; set; }
        public float Interval { get; set; }
        public string PrizeUnit { get; set; } = string.Empty;
        public float StartBlock { get; set; }
        public float TicketPrice { get; set; }
        public string TicketPriceUnit { get; set; } = string.Empty;
    }
}
