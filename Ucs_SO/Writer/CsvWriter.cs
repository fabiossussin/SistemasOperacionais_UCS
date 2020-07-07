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
        private string FileExtension = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) }\\outputContent.csv";
        private List<Organism> fileSorted = new List<Organism>();
        public void WriterFile(List<Organism> newFile)
        {
            var thread = new Thread(() => SortNewFile(newFile));
            thread.Start();

            using (var file = new StreamWriter(this.FileExtension))
                foreach (var line in fileSorted)
                    file.WriteLine($"{line.GeneName}; {line.Name}");

        }

        private void SortNewFile(List<Organism> newFile) =>
            this.fileSorted = newFile.OrderBy(x => x.GeneName).ThenBy(x => x.Name).ToList();

    }
}
