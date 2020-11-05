using ADALotto.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace ADALottoModels
{
    public class ADALottoGameWinner
    {
        public string Address { get; set; } = string.Empty;
        public long DrawBlockId { get; set; }
        public DateTime DrawDate { get; set; }
        public long Prize { get; set; }
        public Transaction? RewardTx { get; set; }
    }
}
