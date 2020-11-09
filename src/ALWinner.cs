using ADALotto.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace ADALottoModels
{
    public class ALWinner
    {
        public string Address { get; set; } = string.Empty;
        public Block DrawBlock { get; set; } = new Block();
        public DateTime DrawDate { get; set; }
        public long Prize { get; set; }
        public Transaction? RewardTx { get; set; }
    }
}
