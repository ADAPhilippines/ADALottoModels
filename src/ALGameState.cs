using ADALotto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADALottoModels
{
    public class ALGameState
    {
        public string HostWallet { get; set; } = string.Empty;
        public long StartBlock { get; set; } = 0;
        public long CurrentPot { get; set; } = 0;
        public IEnumerable<ALResult> PreviousResults { get; set; } = new List<ALResult>();
        public IEnumerable<ALWinner> PreviousWinners { get; set; } = new List<ALWinner>();
        public Transaction? GameGenesisTx { get; set; }
        public ALGameGenesisTxMeta? GameGenesisTxMeta { get; set; }
        public long NextDrawBlock { get; set; } = 0;
        public long PrevDrawBlock { get; set; } = 0;
        public bool IsDrawing { get; set; } = false;
        public bool IsRunning { get; set; } = false;
    }
}
