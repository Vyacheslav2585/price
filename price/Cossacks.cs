using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Globalization; // Добавление директивы using для System.Globalization
using System.Net;
using System.Text.RegularExpressions;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace price
{
    public class Cossacks
    {
    public string F() { 
WebClient client = new WebClient();
    string html = client.DownloadString("https://store.steampowered.com/app/333420/Cossacks_3/");

    // Создание объекта HtmlDocument для анализа страницы
    HtmlDocument doc = new HtmlDocument();
    doc.LoadHtml(html);

// Получение элемента с классом "price"
    var priceElement = doc.DocumentNode.SelectSingleNode("//div[@class='game_purchase_price price']");
    string price = priceElement.InnerText.Trim();
    price = Regex.Replace(price, @"\\u(?<Value>[a-zA-Z0-9]{4})", m => ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString());
    price = Regex.Replace(price, @"[^\u0000-\u007F]+", " ");
            return $"Ціна на козаки: {price.ToString()} грн";
        }
    }
}
