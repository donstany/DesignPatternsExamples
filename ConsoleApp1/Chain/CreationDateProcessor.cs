using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExamples.Adapter;

namespace ConsoleApp1.Chain
{
    public class CreationDateProcessor : IProcessor
    {
        public double Sum { get; set; } = 0;

        public void Process(IBet bet)
        {
            if (bet.CreationDate.DayOfWeek == DayOfWeek.Friday)
            {
                Sum += bet.Stake;
                bet.Status = true;
            }
        }
    }
}
