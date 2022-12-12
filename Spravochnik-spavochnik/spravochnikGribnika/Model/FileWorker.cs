using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spravochnikGribnika.Model
{
    class FileWorker
    {
        public string _path = @"..\..\..\spravochnikGribnika\View\InformationalFile\";

        public async Task<string> ReadFile(string directoryName,string fileName)
        {
            string path = _path + directoryName + @"\" + fileName + ".txt";

            using (StreamReader reader = new StreamReader(path))
            {
                var result = await reader.ReadToEndAsync();
                return result;
            }
        }
    }
}
