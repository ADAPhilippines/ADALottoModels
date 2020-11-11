using ADALotto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADALottoModels
{
    public class ALGameState
    {
        public Block StartBlock { get; set; } = new Block();
        public long CurrentPot { get; set; }
        public IEnumerable<ALResult>? PreviousResults { get; set; }
        public IEnumerable<ALWinner>? PreviousWinners { get; set; }
        public Transaction? GameGenesisTx { get; set; }
        public ALGameGenesisTxMeta? GameGenesisTxMeta { get; set; }
        public Block NextDrawBlock { get; set; } = new Block();
        public Block PrevDrawBlock { get; set; }= new Block();
        public bool IsDrawing { get; set; }
        public bool IsRunning { get; set; }
        public int NextRoundTicketCount { get; set; } = 0;
        public string Version { get; set; } = string.Empty;
    }
}
