using System;
using System.Collections.Generic;
using System.Text;

namespace ADALottoModels
{
    public class AdaLottoGameResults
    {
        public DateTime DrawDate { get; set; }
        public List<string> Numbers { get; set; }
        public float Prize { get; set; }
    }
}
