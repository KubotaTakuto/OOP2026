using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class Take20Processor : ITextFileService {
        private int _count = 0;

        public void Initialize(string fname) => _count = 0;

        public void Excute(string line) => Console.WriteLine(line);

        public void Terminate() => Console.WriteLine("{0} 行", _count);
    }
}
