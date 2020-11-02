using ADALottoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADALotto.Models
{
    public class Transaction
    {
        public float? Id { get; set; }
        public float? Block { get; set; }
        public IEnumerable<TransactionMeta>? TxMetadata { get; set; }
        public IEnumerable<TransactionIn>? InTxIns { get; set; }
    }
}
