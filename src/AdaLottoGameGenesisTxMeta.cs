using ADALottoModels.Enumerations;
using ADALottoModels.Interfaces;

namespace ADALotto.Models
{
    public class ADALottoGameGenesisTxMeta : IADALottoGameTxMeta
    {
        public GameTxMetaType Type { get; set; } = GameTxMetaType.Genesis;
        public int Digits { get; set; }
        public int Interval { get; set; }
        public float Prize { get; set; }
        public string BasePrizeUnit { get; set; } = string.Empty;
        public float TicketPrice { get; set; }
        public string TicketPriceUnit { get; set; } = string.Empty;
        public bool IsPermutable { get; set; }
    }
}
