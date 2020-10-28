using System;
using System.Collections.Generic;
using System.Text;

namespace ADALottoModels
{
    public class AdaLottoGameResults
    {
        public DateTime DrawDate { get; set; }
        public List<ADALottoWinningBlock> Numbers { get; set; } = new List<ADALottoWinningBlock>();
        public float Prize { get; set; }
    }
}
