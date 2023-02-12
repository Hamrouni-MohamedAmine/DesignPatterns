using Builder;

Console.Title = "Builder";

var garage = new Garage();

var miniBuilder = new MiniBuilder();
var BMWBuilder = new BMWBuilder();

garage.Construct(miniBuilder);
Console.WriteLine(miniBuilder.Car.ToString());

garage.Construct(BMWBuilder);
garage.Show();

Console.ReadKey();