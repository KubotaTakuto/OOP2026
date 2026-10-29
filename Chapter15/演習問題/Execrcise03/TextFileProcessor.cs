using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class TextFileProcessor {
        private ITextFileService _service;

        public TextFileProcessor(ITextFileService service) {
            _service = service;
        }

        public void Run(string fileName) {
            _service.Initialize(fileName);
            var lines = File.ReadLines(fileName);

            int _count = 0;
            foreach (var line in File.ReadLines(fileName)) {
                if (_count >= 20) {
                    break;
                }

                _service.Excute(line);
                _count++;
            }
        }
    }
}
