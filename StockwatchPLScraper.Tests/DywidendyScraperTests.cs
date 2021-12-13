using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockwatchPLScraper.Tests
{
    [TestClass]
    public class DywidendyScraperTests
    {
        private DywidendyScraper _ts;

        public DywidendyScraperTests()
        {
            _ts = new DywidendyScraper();
        }

        [TestMethod]
        public async Task Works()
        {
            var result = await _ts.Scrape();
        }

        [TestMethod]
        public async Task WorksProponowana()
        {
            var result = await _ts.Scrape("proponowana");
        }

        [TestMethod]
        public async Task WorksUchwalona()
        {
            var result = await _ts.Scrape("uchwalona");
        }

        [TestMethod]
        public async Task WorksWyplacona()
        {
            var result = await _ts.Scrape("wyplacona");
        }
    }
}