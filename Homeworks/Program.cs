using HtmlAgilityPack;


// Задача с парсером валют и энумератором
Main(CurrencyType.USD);
void Main(CurrencyType type)
{
        // Загрузка HTML-документа
        var url = "https://www.rbc.ru/quote/ticker/72413"; // Укажите URL
        HtmlWeb web = new HtmlWeb();
        var doc = web.Load(url);

        // Пример: получение всех заголовков h1
        if (doc.DocumentNode != null)
        {
            switch (type)
            {
                case CurrencyType.USD:
                {
                    HtmlNode? currencyusdNode =
                        doc.DocumentNode.SelectSingleNode(
                            "//*[@id=\"maincontent\"]/div/div[2]/div[1]/div[1]/div[1]/div/div[2]/span[1]/text()[2]");
                    Console.WriteLine($"\t{HtmlEntity.DeEntitize(currencyusdNode.InnerText)}");
                    break;
                }
                case CurrencyType.EUR:
                {
                    HtmlNode? currencyeurNode =
                        doc.DocumentNode.SelectSingleNode(
                            "//*[@id=\"maincontent\"]/div/div[2]/div[1]/div[1]/div[1]/div/div[2]/span[1]");
                    Console.WriteLine($"\t{HtmlEntity.DeEntitize(currencyeurNode.InnerText)}");
                    break;
                }

            }
        }
}
enum CurrencyType {
        USD,
        EUR,
        GBP,
        JPY
}







