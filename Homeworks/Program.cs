using Homeworks;
using HtmlAgilityPack;


// Задача с парсером валют и энумератором

// Main(CurrencyType.EUR);
// void Main(CurrencyType type)
// {
//         
//         var url = "https://www.rbc.ru/quote/ticker/72413";
//     
//         var url2 = "https://www.rbc.ru/quote/ticker/72383";
//         HtmlWeb web = new HtmlWeb();
//         var doc = web.Load(url);
//         var doc2 = web.Load(url2);
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
//                             "//*[@id=\"maincontent\"]/div/div[2]/div[1]/div[1]/div[1]/div/div[2]/span[1]");
//                     Console.WriteLine($"\t{HtmlEntity.DeEntitize(currencyusdNode.InnerText)}");
//                     break;
//                 }
//                 case CurrencyType.EUR:
//                 {
//                     HtmlNode? currencyeurNode =
//                         doc2.DocumentNode.SelectSingleNode(
//                             "//*[@id=\"maincontent\"]/div/div[2]/div[1]/div[1]/div[1]/div/div[2]/span[1]");
//                     Console.WriteLine($"\t{HtmlEntity.DeEntitize(currencyeurNode.InnerText)}");
//                     break;
//                 }
//
//             }
//         }
// }


//  рекурсия фибоначи
// int Fibonacci(int x)
// {
//    int result = 0;
//    if (x==0 || x==1) return x;
//    return result + Fibonacci(x - 1) + Fibonacci(x - 2);
// }
// int a = Fibonacci(6);
// Console.WriteLine(a);


// enum CurrencyType {
//         USD,
//         EUR,
//         GBP,
//         JPY
// }

// Задача классы (автобаза)

// var dd = new Dispatcher("Dmitriy");
// var cc = new Reys(11,"Krd", "Moscov", 30,10000);
// var a=new Car("Jeep", "Kamaz", 250);
// var v=new Driver("John");
// dd.give_car_to_reys(cc,a);
// // dd.BlockDriver(v);
// dd.give_reys(v,cc);
// Console.WriteLine(v.Reys.Number);
// v.MarkAsCompleted();

// Задача классы (ЖДстанция)

// var jd = new Station("KRdvokzal");
// var poezd = new Train(11,"Krd", "12:30","03.05", 1000);
// var dima = new Passanger("Dmitriy");
// jd.AddTrain(poezd);
// dima.Zayavka(jd);






