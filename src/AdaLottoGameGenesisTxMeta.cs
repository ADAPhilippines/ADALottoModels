using ADALottoModels.Enumerations;
using ADALottoModels.Interfaces;

namespace ADALotto.Models
{
    public class ADALottoGameGenesisTxMeta : IADALottoGameTxMeta
    {
        public GameTxMetaType Type { get; set; } = GameTxMetaType.Genesis;
        public float Id { get; set; }
        public float Prize { get; set; }
        public int Digits { get; set; }
        public float Interval { get; set; }
        public string PrizeUnit { get; set; } = string.Empty;
        public float StartBlock { get; set; }
        public float TicketPrice { get; set; }
        public string TicketPriceUnit { get; set; } = string.Empty;
    }
}
