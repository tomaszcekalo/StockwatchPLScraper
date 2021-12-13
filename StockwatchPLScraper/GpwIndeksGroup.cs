using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockwatchPLScraper
{
    public class GpwIndeksGroup
    {
        public GpwIndeksGpwSkladScraper Gpw { get; set; }
        public GpwIndeksNcindexSkladScraper NcIndex { get; set; }
    }
}