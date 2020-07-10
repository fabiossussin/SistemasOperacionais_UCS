using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucs_SO.Model;
using Ucs_SO.Writer;

namespace Ucs_SO.Reader
{
    public class CsvReader
    {

        private string FileExtension = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) }\\LeitorCSV\\intergenidb.csv";

        public void FileReader()
        {
            var newFile = new List<Organism>();

            Parallel.ForEach(
                File.ReadLines(this.FileExtension).Select(line => line.Split('\t')),
                parts =>
                {
                    var content = parts[0].Split(';');

                    newFile.Add(new Organism
                    {
                        GeneName = content[0],
                        Name = content[1]
                    });
                });

            new CsvWriter().WriterFile(newFile);

        }

    }
}
