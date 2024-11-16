using System.Runtime.InteropServices;
using System.Text.Json;
//Задача 1
int idProduct = 0;
Product[] products = new Product[5];
string jsonString = null;
for (int i = 0; i < products.Length; i++)
{
    idProduct++;
    Console.Write("Введите цену продукта:");
    bool resultParse = double.TryParse(Console.ReadLine(), out double priceProduct);
    if (!resultParse)
    {
        i--;
        idProduct--;
        Console.WriteLine("Неправильный формат ввода. Попробуйте еще раз.");
        continue;
    }
    Console.Write("Введите имя продукта:");
    string nameProduct = Console.ReadLine();
    Product product = new Product(idProduct, nameProduct, priceProduct);   
    products[i] = product;
    Console.WriteLine();
}
jsonString = JsonSerializer.Serialize<Product[]>(products);
Console.WriteLine(jsonString);
string path = "..\\..\\Products.json";
if(!File.Exists(path))
{
    File.Create(path);
}
File.WriteAllText(path, string.Empty);
if (!(jsonString == File.ReadAllText(path)))
    File.WriteAllText(path, jsonString);

//Задача 2
products = new Product[5];
products = JsonSerializer.Deserialize<Product[]>(jsonString);
double maxPrice = 0;
string maxName = null;
for (int i = 0; i < products.Length; i++)
{
    if (products[i].priceProduct > maxPrice)
    {
        maxPrice = products[i].priceProduct;
        maxName = products[i].nameProduct;
    }
}
Console.WriteLine($"Самый дорогой продукт:\nНаименование:{maxName} Цена:{maxPrice}");
Console.ReadKey();

public class Product
{
    public int idProduct { get; set; }
    public string nameProduct { get; set; }
    public double priceProduct { get; set; }
    public Product(int idProduct, string nameProduct, double priceProduct)
    {
        this.idProduct = idProduct;
        this.nameProduct = nameProduct;
        this.priceProduct = priceProduct;
    }
}