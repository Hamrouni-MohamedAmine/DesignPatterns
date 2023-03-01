using TemplateMethod;

Console.Title = "Template Method";

ExchangeMailParser exchangeMailParser= new();
Console.WriteLine(exchangeMailParser.ParseMailBody("123-456"));
Console.WriteLine();

ApacheMailParser apacheMailParser = new();
Console.WriteLine(apacheMailParser.ParseMailBody("456-789"));
Console.WriteLine();

EudoraMailParser eudoraMailParser = new();
Console.WriteLine(eudoraMailParser.ParseMailBody("789-123"));


Console.ReadKey();