using ADALottoModels.Enumerations;
using ADALottoModels.Interfaces;
using System.Collections.Generic;

namespace ADALottoModels
{
    public class ADALottoGameTicketTxMeta : IADALottoGameTxMeta
    {
        public GameTxMetaType Type { get; set; } = GameTxMetaType.TicketPurchase;
        public IEnumerable<int>? Combination { get; set; }
    }
}
