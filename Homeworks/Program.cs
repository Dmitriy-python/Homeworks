using HtmlAgilityPack;


// Задача с парсером валют и энумератором

// Main(CurrencyType.USD);
// void Main(CurrencyType type)
// {
//         
//         var url = "https://www.rbc.ru/quote/ticker/72413"; 
//         HtmlWeb web = new HtmlWeb();
//         var doc = web.Load(url);
//         
//            
//         if (doc.DocumentNode != null)
//         {
//             switch (type)
//             {
//                 case CurrencyType.USD:
//                 {
//                     HtmlNode? currencyusdNode =
//                         doc.DocumentNode.SelectSingleNode(
//                             "//*[@id=\"maincontent\"]/div/div[2]/div[1]/div[1]/div[1]/div/div[2]/span[1]/text()[2]");
//                     Console.WriteLine($"\t{HtmlEntity.DeEntitize(currencyusdNode.InnerText)}");
//                     break;
//                 }
//                 case CurrencyType.EUR:
//                 {
//                     HtmlNode? currencyeurNode =
//                         doc.DocumentNode.SelectSingleNode(
//                             "//*[@id=\"maincontent\"]/div/div[2]/div[1]/div[1]/div[1]/div/div[2]/span[1]");
//                     Console.WriteLine($"\t{HtmlEntity.DeEntitize(currencyeurNode.InnerText)}");
//                     break;
//                 }
//
//             }
//         }
// }


//  рекурсия фибоначи
int Fibonacci(int x)
{
   int result = 0;
   if (x==0 || x==1) return x;
   return result + Fibonacci(x - 1) + Fibonacci(x - 2);
}
int a = Fibonacci(6);
Console.WriteLine(a);


// enum CurrencyType {
//         USD,
//         EUR,
//         GBP,
//         JPY
// }


