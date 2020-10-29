using System;
using System.Collections.Generic;
using System.Text;

namespace ADALottoModels
{
    public class ADALottoGameWinner
    {
        public string Address { get; set; } = string.Empty;
        public DateTime DrawDate { get; set; }
        public double Prize { get; set; }
    }
}
