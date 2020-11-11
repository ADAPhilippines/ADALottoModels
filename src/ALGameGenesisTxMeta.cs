using ADALottoModels.Enumerations;
using ADALottoModels.Interfaces;

namespace ADALotto.Models
{
    public class ALGameGenesisTxMeta : IALGameTxMeta
    {
        public GameTxMetaType Type { get; set; } = GameTxMetaType.Genesis;
        public int Digits { get; set; }
        public int BlockInterval { get; set; }
        public long BasePrize { get; set; }
        public string BasePrizeUnit { get; set; } = string.Empty;
        public long TicketPrice { get; set; }
        public string TicketPriceUnit { get; set; } = string.Empty;
        public bool IsPermutable { get; set; }
        public double WinnerPrizeRatio { get; set; }
    }
}
