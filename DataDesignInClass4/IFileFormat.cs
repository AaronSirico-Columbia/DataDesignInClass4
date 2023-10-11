using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDesignInClass4
{
    public interface IFileFormat
    {
        public string Path { get; set; }

        public string Exstension { get; set; }

        public string Delimeter { get; set; }

        public void SetFile(string _path, string _exstension, string _delimeter)
        {
            this.Path = _path;
            this.Exstension = _exstension;
            this.Delimeter = _delimeter; 
        }
    }


}
