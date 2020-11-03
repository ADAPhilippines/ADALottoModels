using ADALotto.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace ADALottoModels
{
    public class ADALottoGameWinner
    {
        public string Address { get; set; } = string.Empty;
        public float DrawBlockId { get; set; }
        public DateTime DrawDate { get; set; }
        public double Prize { get; set; }
        public Transaction? RewardTx { get; set; }
    }
}
