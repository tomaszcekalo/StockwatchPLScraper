using AngleSharp;
using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockwatchPLScraper
{
    public class DywidendyScraper
    {
        public async Task Scrape()
        {

            var config = Configuration.Default.WithDefaultLoader();
            var address = "https://www.stockwatch.pl/dywidendy/";
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(address);
            var akcje = ParseAkcje(document);
        }

        public object ParseAkcje(IDocument document)
        {
            var cellSelector = "";
            var cells = document.QuerySelectorAll(cellSelector);
            return cells;
        }
    }
}
