using System;

namespace DesignPatternsExamples.Entities
{
    public class CasinoBet
    {
        public string CasinoProvider { get; set; }
        public string GameProvider { get; set; }
        public string GameID { get; set; }
        public string CreationDate { get; set; }
        public string Stake { get; set; }

        public class Builder
        {
            private CasinoBet bet;

            private Builder()
            {
                bet = new CasinoBet();
            }

            public static Builder newBuilder()
            {
                return new Builder();
            }

            public Builder SetCasinoProvider(string casinoProvider)
            {
                bet.CasinoProvider = casinoProvider;
                return this;
            }

            public Builder SetGameProvider(string gameProvider)
            {
                bet.GameProvider = gameProvider;
                return this;
            }

            public Builder SetGameID(string gameID)
            {
                bet.GameID = gameID;
                return this;
            }

            public Builder SetCreationDate (string creationDate)
            {
                bet.CreationDate = creationDate;
                return this;
            }

            public Builder SetStake (string stake)
            {
                bet.Stake = stake;
                return this;
            }


            public CasinoBet Build()
            {
                return bet;
            }
        }

    }
}
