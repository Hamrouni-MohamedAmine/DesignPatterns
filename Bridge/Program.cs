using Bridge;

Console.Title = "Bridge";

var noCoupon = new NoCoupon();
var oneEuroCoupon = new OneEuroCoupon();

var meatBasedMenu = new MeatBasedMenu(noCoupon);
Console.WriteLine($@"Meat based Menu, no Coupon: {meatBasedMenu.CalculatePrice()} Euro.");

meatBasedMenu = new MeatBasedMenu(oneEuroCoupon);
Console.WriteLine($@"Meat based Menu, one euro Coupon: {meatBasedMenu.CalculatePrice()} Euro.");

var vegetarienMenu = new VegetarienMenu(noCoupon);
Console.WriteLine($@"Vegetarien Menu, no Coupon: {vegetarienMenu.CalculatePrice()} Euro.");

vegetarienMenu = new VegetarienMenu(oneEuroCoupon);
Console.WriteLine($@"Vegetarien Menu, one euro Coupon: {vegetarienMenu.CalculatePrice()} Euro.");

Console.ReadLine();