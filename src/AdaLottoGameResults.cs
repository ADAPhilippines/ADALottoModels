using System;
using System.Collections.Generic;
using System.Text;

namespace ADALottoModels
{
    public class ADALottoGameResults
    {
        public DateTime DrawDate { get; set; }
        public List<ADALottoWinningBlock> Numbers { get; set; } = new List<ADALottoWinningBlock>();
        public long Prize { get; set; }
        public int WinnerCount { get; set; } = 0;
    }
}
