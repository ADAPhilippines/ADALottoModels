using ADALottoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADALotto.Models
{
    public class BlockChainInfo
    {
        public DataConnection<Block>? Blocks { get; set; }
        public DataConnection<TransactionOut>? TxOuts { get; set; }
    }
}
