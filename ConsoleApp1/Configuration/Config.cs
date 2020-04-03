
using System.IO;

namespace DesignPatternsExamples.Configuration
{
    public class Config
    {
        public string SportBetsFile { get; private set;  }
        public string CasinoBetsFile { get; private set; }

        private Config(string sportsBetsFile, string casinoBetsFile)
        {
            this.SportBetsFile = sportsBetsFile;
            this.CasinoBetsFile = casinoBetsFile;
        }

        private static Config _instance;

        public static Config INSTANCE
        {
            get
            {
                if (_instance == null)
                {
                    string currentDirCasino = Directory.GetCurrentDirectory();
                    var parent = new DirectoryInfo(currentDirCasino).Parent.Parent.FullName;
                    var pathToDataCasino = Path.Combine(parent, "Files", "CasinoBets.txt");
                    var pathToDataSports = Path.Combine(parent, "Files", "SportBets.txt");
                    //_instance = new Config(@"C:\temp\SportBets.txt", @"C:\temp\CasinoBets.txt");
                    _instance = new Config(pathToDataSports, pathToDataCasino);
                }
                return _instance;
            }
        }

        //public static Config GetInstance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new Config(@"C:\temp\SportBets.txt", @"C:\temp\CasinoBets.txt");
        //    }
        //    return _instance;
        //}

    }
}
