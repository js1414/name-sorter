using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Service
{
    public class FileNameReader : INameReader
    {
        private readonly string _filePath;
        public FileNameReader(string filePath) => _filePath = filePath;

        public IEnumerable<string> ReadNames()
        {
            //return File.ReadAllLines(_filePath).Where(line => !string.IsNullOrWhiteSpace(line));

            try
            {
                if (string.IsNullOrWhiteSpace(_filePath))
                    throw new ArgumentException("File path cannot be null or empty.", nameof(_filePath));

                if (!File.Exists(_filePath))
                    throw new FileNotFoundException($"Input file not found: {_filePath}");

            }
            catch { }

            // returns a sequence of non-empty lines from the file.
            return File.ReadAllLines(_filePath).Where(line => !string.IsNullOrWhiteSpace(line));


        }
    }
}
