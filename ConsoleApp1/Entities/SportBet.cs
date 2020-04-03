using System;

namespace DesignPatternsExamples.Entities
{
    public class SportBet
    {
        public string Branch { get; set; }
        public string MasterEventID { get; set; }
        public string EventID { get; set; }
        public string Stake { get; set; }
        public string LineID { get; set; }
        public string CreationDate { get; set; }


        public class Builder
        {
            private SportBet bet {get; set; }

            private Builder()
            {
                bet = new SportBet();
            }

            public static Builder NewBuilder()
            {
                return new Builder();
            }

            public Builder SetBranch (string branch)
            {
                bet.Branch = branch;
                return this;
            }

            public Builder SetMasterEventID (string masterEventID)
            {
                bet.MasterEventID = masterEventID;
                return this;
            }

            public Builder SetEventID (string eventID)
            {
                bet.EventID = eventID;
                return this;
            }

            public Builder SetStake(string stake)
            {
                bet.Stake = stake;
                return this;
            }

            public Builder SetLineID (string lineID)
            {
                bet.LineID = lineID;
                return this;
            }

            public Builder SetCreationDate(string creationDate)
            {
                bet.CreationDate = creationDate;
                return this;
            }

            public SportBet Build()
            {
                return bet;
            }
        }
    }
}
