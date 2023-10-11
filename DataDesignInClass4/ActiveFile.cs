using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDesignInClass4
{
    public class ActiveFile : IFileFormat
    {
        public string Path { get; set; }

        public string Exstension { get; set; }

        public string Delimeter { get; set; }

        List<string> ExstensionList = new List<string>() { };
        


        public ActiveFile(string path)
        {
            Path = path;
            ExstensionList.Add(".txt");
            ExstensionList.Add(".csv");
        }

        public void SetFile(string path, string exstension, string delimeter)
        {
            this.Path = path;
            this.Exstension = exstension;
            this.Delimeter = delimeter;
        }



        public string SetDelim(string path)
        {
            
            foreach (string EXT in ExstensionList)
            {
                if (path.Contains(EXT))
                {
                    switch (EXT)
                    {
                        case ".txt":
                            this.Exstension = EXT;
                            return "|";
                            break;
                        case ".csv":
                            this.Exstension = EXT;
                            return ",";
                            break;

                        default:
                            return null;
                            break;

                    }
                }
            }
        return null;
        }

    }

    
}




