using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ucs_SO.Model;

namespace Ucs_SO.Writer
{
    class CsvWriter
    {
        private string FileExtension = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) }\\LeitorCSV\\outputContent.csv";
        private static List<Organism> fileSorted = new List<Organism>();
        public void WriterFile(List<Organism> newFile)
        {
            Task.Run(() =>
            {
                this.SortNewFile(newFile);
            }).Wait();

            using (var file = new StreamWriter(this.FileExtension))
                foreach (var line in fileSorted)
                    file.WriteLine($"{line.GeneName}; {line.Name}");

        }

        private void SortNewFile(List<Organism> newFile) =>
            fileSorted = newFile.OrderBy(x => x.GeneName).ThenBy(x => x.Name).ToList();

    }
}
