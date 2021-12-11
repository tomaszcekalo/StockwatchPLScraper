using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockwatchPLScraper
{
    public class GpwGroup
    {
        public GpwIndeksyScraper Indeksy { get; set; }
        public GpwSektoryScraper Sektory { get; set; }
    }
}