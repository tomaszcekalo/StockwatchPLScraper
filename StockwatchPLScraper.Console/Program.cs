// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using StockwatchPLScraper;

var _ts = new DywidendyScraper();
var result = await _ts.Scrape();
var serialized = JsonConvert.SerializeObject(result, Formatting.Indented);
Console.WriteLine(serialized);