using DesignPatternsExamples.Entities;
using System;
using System.Globalization;


namespace DesignPatternsExamples.Adapter
{
    public class SportBetAdapter : IBet
    {
        private SportBet _bet;

        public SportBetAdapter(SportBet bet)
        {
            this._bet = bet;
        }

        public DateTime CreationDate => DateTime.ParseExact(_bet.CreationDate, "yyyy-mm-dd", CultureInfo.InvariantCulture);

        public double Stake => double.Parse(_bet.Stake);

        public bool Status { get; set; } = false;
    }
}
