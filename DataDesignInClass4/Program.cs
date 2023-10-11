using DataDesignInClass4;

var Path = ($"{Directory.GetCurrentDirectory()}\\files");
var FileList = Directory.GetFiles(Path).Where(fn => !fn.Contains("_out")).ToList();
var OutFileList = Directory.GetFiles(Path).Where(fn => fn.Contains("_out")).ToList();
List<string> dataList = new List<string>();



foreach (var file in FileList)
{
    ActiveFile AFile = new ActiveFile(file);
    
    using (StreamReader sr = new StreamReader(AFile.Path)) 
    {
        var line = sr.ReadLine();
       
        while (line != null)
        {
            var data = line.Split(AFile.SetDelim(AFile.Path)).ToArray();

            if (file.Contains(".csv") == true)
            {
                dataList.Add(data[0]);
                dataList.Add(data[1]);
                dataList.Add(data[2]);
            }
            else if (file.Contains(".txt"))
            {

                dataList.Add(data[3]);
                dataList.Add(data[4]);
                dataList.Add(data[5]);
            }

            line = sr.ReadLine();

            
        }

    }
}



foreach (var OFile in OutFileList)
{
    using (StreamWriter sw = new StreamWriter(OFile))
    {
        int i = 1;
        int x = 1;
        for (x = 1; x < 4; x++)
        {
            sw.Write($"\nLine#{x} :");

            foreach (string line2 in dataList)
            {
                sw.Write($"Field#{i}= {line2} ==> ");

                i++;
                if (i == 7)
                {
                    i = 1;
                    break;
                }
            }
        }
    }
       
}




