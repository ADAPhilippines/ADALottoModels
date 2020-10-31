using ADALottoModels.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADALottoModels.Interfaces
{
    public interface IADALottoGameTxMeta
    {
        public GameTxMetaType Type { get; set; }
    }
}
