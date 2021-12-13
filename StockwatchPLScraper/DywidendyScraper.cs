using AngleSharp;
using AngleSharp.Dom;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockwatchPLScraper
{
    public class DywidendyScraper
    {
        public async Task<object> Scrape(string s = null)
        {
            var config = Configuration.Default.WithDefaultLoader();
            var address = "https://www.stockwatch.pl/dywidendy/";
            var url = new Url(address);
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            if (!string.IsNullOrEmpty(s))
            {
                var param = new Dictionary<string, string>() { { "s", s } };
                url = new Url(QueryHelpers.AddQueryString(address, param));
            }

            var context = BrowsingContext.New(config);

            var document = await context.OpenAsync(url);
            var akcje = ParseAkcje(document);
            return akcje;
        }

        public object ParseAkcje(IDocument document)
        {
            var tab = document.QuerySelector("#DividendsTab");
            var rows = tab.QuerySelectorAll("tbody tr").Select(x => ParseRow(x));
            return rows;
        }

        private object ParseRow(IElement x)
        {
            var cells = x.QuerySelectorAll("td");
            return new
            {
                LLCName = cells[0].TextContent.Trim(),
                LLCHref = cells[0].QuerySelector("a")
                    ?.Attributes["href"]?.Value,
                DateRange = cells[1].TextContent.Trim(),
                DYPerShare = cells[2].TextContent,
                DYPercentage = cells[3].TextContent,
                RecordDate = cells[4].TextContent,
                ExDividendDate = cells[5].TextContent,
                StateOfPayout = cells[6].TextContent.Trim(),
                AnnounceDate = cells[7].TextContent
            };
        }
    }
}