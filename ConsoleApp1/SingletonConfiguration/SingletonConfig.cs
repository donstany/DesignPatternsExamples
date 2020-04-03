
using System.IO;

namespace DesignPatternsExamples.Configuration
{
    public class SingeltonConfig
    {
        public string SportBetsFile { get; private set;  }
        public string CasinoBetsFile { get; private set; }

        private SingeltonConfig(string sportsBetsFile, string casinoBetsFile)
        {
            this.SportBetsFile = sportsBetsFile;
            this.CasinoBetsFile = casinoBetsFile;
        }

        private static SingeltonConfig _instance;

        public static SingeltonConfig INSTANCE
        {
            get
            {
                if (_instance == null)
                {
                    string currentDirCasino = Directory.GetCurrentDirectory();
                    var parent = new DirectoryInfo(currentDirCasino).Parent.Parent.FullName;
                    var casinoBetsFile = Path.Combine(parent, "Files", "CasinoBets.txt");
                    var sportsBetsFile = Path.Combine(parent, "Files", "SportBets.txt");
                   _instance = new SingeltonConfig(sportsBetsFile, casinoBetsFile);
                }
                return _instance;
            }
        }

    }
}
