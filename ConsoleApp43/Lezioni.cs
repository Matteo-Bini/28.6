using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Lezioni : Corso
    {
        public string descrizione { get; set; }
        public DateTime data { get; set; }
        public int orainizio { get; set; }
        public int durata { get; set; }
        public string  docente { get; set; }
        public int aula { get; set; }
    }
}
