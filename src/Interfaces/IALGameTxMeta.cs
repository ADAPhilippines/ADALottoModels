using ADALottoModels.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADALottoModels.Interfaces
{
    public interface IALGameTxMeta
    {
        public GameTxMetaType Type { get; set; }
    }
}
