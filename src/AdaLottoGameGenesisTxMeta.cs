using ADALottoModels.Enumerations;
using ADALottoModels.Interfaces;

namespace ADALotto.Models
{
    public class ADALottoGameGenesisTxMeta : IADALottoGameTxMeta
    {
        public GameTxMetaType Type { get; set; } = GameTxMetaType.Genesis;
        public int Digits { get; set; }
        public int BlockInterval { get; set; }
        public float BasePrize { get; set; }
        public string BasePrizeUnit { get; set; } = string.Empty;
        public float TicketPrice { get; set; }
        public string TicketPriceUnit { get; set; } = string.Empty;
        public bool IsPermutable { get; set; }
    }
}
