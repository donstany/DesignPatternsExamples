using DesignPatternsExamples.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Chain
{
    public interface IProcessor
    {
        void Process(IBet bet);
    }
}
