using DataDesignInClass4;

var Path = ($"{Directory.GetCurrentDirectory()}\\files");
var FileList = Directory.GetFiles(Path).Where(fn => !fn.Contains("_out")).ToList();
var OutFileList = Directory.GetFiles(Path).Where(fn => fn.Contains("_out")).ToList();
List<string> data = new List<string>();


int x = 0;


foreach (var file in FileList)
{
    ActiveFile AFile = new ActiveFile(file);
    
    using (StreamReader sr = new StreamReader(AFile.Path)) 
    {
        var line = sr.ReadLine();

        while (line != null)
        {

            data = line.Split(AFile.SetDelim(AFile.Path)).ToList();
            line = sr.ReadLine();

        }

    }
}

foreach (var OFile in OutFileList)
{


    using (StreamWriter sw = new StreamWriter(OFile))
    {
        int i = 1;

        foreach (string line2 in data)
        {
            sw.WriteLine($"Field#{i}= {line2} ==> ");
            i++;
        }
    }
}





