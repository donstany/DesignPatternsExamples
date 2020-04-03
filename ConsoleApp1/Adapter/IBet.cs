using System;

namespace DesignPatternsExamples.Adapter
{
    public interface IBet
    {
        DateTime CreationDate { get; }
        double Stake { get; }

        bool Status { get; set; }
    }
}
