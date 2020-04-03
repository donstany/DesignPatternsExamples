using DesignPatternsExamples.Entities;
using DesignPatternsExamples.Configuration;
using System.Collections.Generic;
using System.IO;
using DesignPatternsExamples.Adapter;
using ConsoleApp1.Chain;
using System;

namespace DesignPatternsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
    
            List<IBet> listОfBets = new List<IBet>();
            StreamReader readerOfSportsBets;
            StreamReader readerOfCasinoBets;
            string line;

            using (readerOfSportsBets = new StreamReader(Config.INSTANCE.SportBetsFile))
            {
                while ((line = readerOfSportsBets.ReadLine()) != null)
                {
                    string[] props = line.Split(',');
                    SportBet bet = SportBet.Builder.NewBuilder()
                        .SetBranch(props[0])
                        .SetEventID(props[1])
                        .SetMasterEventID(props[2])
                        .SetStake(props[3])
                        .SetLineID(props[4])
                        .SetCreationDate(props[5])
                        .Build();
                    listОfBets.Add(new SportBetAdapter(bet));
                }
            }


            using (readerOfCasinoBets = new StreamReader(Config.INSTANCE.CasinoBetsFile))
            {
                while ((line = readerOfCasinoBets.ReadLine()) != null)
                {
                    string[] props = line.Split(',');
                    listОfBets.Add(new CasinoBetAdapter(CasinoBet.Builder.newBuilder()
                        .SetCasinoProvider(props[0])
                        .SetGameProvider(props[1])
                        .SetGameID(props[2])
                        .SetStake(props[4])
                        .SetCreationDate(props[3])
                        .Build()));
                }
            }

            var stakeProcessor = new StakeProcessor();
            var casinoProcessor = new CreationDateProcessor();
            foreach (var bet in listОfBets)
            {
                stakeProcessor.Process(bet);
                casinoProcessor.Process(bet);
            }

            Console.WriteLine(stakeProcessor.Sum);
            Console.WriteLine(casinoProcessor.Sum);
            Console.ReadLine();

        }
    }
}
