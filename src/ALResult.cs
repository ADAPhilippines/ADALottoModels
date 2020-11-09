using System;
using System.Collections.Generic;
using System.Text;

namespace ADALottoModels
{
    public class ALResult
    {
        public DateTime DrawDate { get; set; }
        public List<ALWinningBlock> Numbers { get; set; } = new List<ALWinningBlock>();
        public long Prize { get; set; }
        public int WinnerCount { get; set; } = 0;
    }
}
