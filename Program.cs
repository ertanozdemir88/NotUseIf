using NotUseIf.Domains;
using NotUseIf.Services;

var physicalProduct = new PhysicalProduct(100, 20);
var digitalProduct = new DigitalProduct(50);
var serviceProduct = new ServiceProduct(200, 1.5m);

var order = new Order();
order.AddProduct(physicalProduct);
order.AddProduct(digitalProduct);
order.AddProduct(serviceProduct);

decimal totalPrice = order.CalculateTotalPrice();
Console.WriteLine($"Toplam Sipariş Fiyatı: {totalPrice} TL");
