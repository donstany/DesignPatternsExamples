using DesignPatternsExamples.Entities;
using System;
using System.Globalization;

namespace DesignPatternsExamples.Adapter
{
    public class CasinoBetAdapter : IBet
    {
        private CasinoBet _bet;

        public CasinoBetAdapter(CasinoBet bet)
        {
            this._bet = bet;
        }

        public DateTime CreationDate => DateTime.ParseExact(this._bet.CreationDate, "yyyy-mm-dd", CultureInfo.InvariantCulture);

        public double Stake => double.Parse(this._bet.Stake);

        public bool Status { get; set; } = false;
    }
}
