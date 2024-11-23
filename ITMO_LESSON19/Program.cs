List<Computer> computers = new List<Computer>
{
    new Computer(1, "PC1", "Proc1", 1000, 8, 255, 6, 45000, 3),
    new Computer(2, "PC2", "Proc1", 1070, 16, 255, 6, 46000, 3),
    new Computer(3, "PC3", "Proc2", 1000, 8, 255, 6, 43000, 3),
    new Computer(4, "PC4", "Proc8", 10000, 16, 255, 6, 45000, 3),
    new Computer(5, "PC5", "Proc8", 10800, 16, 255, 6, 45000, 3),
    new Computer(4, "PC6", "Proc9", 100000, 16, 255, 6, 45000, 31),
};
Console.Write("Введите название процессора:");
string nameProc = Console.ReadLine();
List<Computer> byProcessor = (from comp in computers
                             where comp.processor == nameProc
                             select comp).ToList();
Console.WriteLine("По процессору:");
foreach (Computer comp in byProcessor)
{
    Console.WriteLine($"{comp.markName} {comp.processor}");
}
Console.Write("Введите объем ОЗУ:");
double ramInput = Convert.ToDouble(Console.ReadLine());
List<Computer> byRAM = (from comp in computers
                              where comp.RAM >= ramInput
                              select comp).ToList();
Console.WriteLine("По ОЗУ:");
foreach (Computer comp in byRAM)
{
    Console.WriteLine($"{comp.markName} {comp.RAM}");
}
List<Computer> byPrice = (from comp in computers
                        orderby comp.price
                        select comp).ToList();
Console.WriteLine("Сортировка по стоимости:");
foreach (Computer comp in byPrice)
{
    Console.WriteLine($"{comp.markName} {comp.price}");
}
var byGroupProcessor = (from comp in computers
                                   group comp by comp.processor into g
                                   select new
                                   {
                                       pc = from pc in g select pc
                                   }
                                  ).ToList();
                                    
Console.WriteLine("Группировка по процессору:");
foreach (var comp in byGroupProcessor)
{
    foreach (var compp in comp.pc)
    {
        Console.WriteLine($"{compp.markName} {compp.processor}");
    }
}
Computer maxPricePC = (from pc in computers
                       orderby pc.price descending
                       select pc).Take(1).FirstOrDefault();
Console.WriteLine("Компьютер с максимальной стоимостью:");
if (maxPricePC != null)
{
    Console.WriteLine($"{maxPricePC.markName} {maxPricePC.price}");
}
Computer minPricePC = (from pc in computers
                       orderby pc.price
                       select pc).Take(1).FirstOrDefault();
Console.WriteLine("Компьютер с минимальной стоимостью:");
if (minPricePC != null)
{
    Console.WriteLine($"{minPricePC.markName} {minPricePC.price}");
}
Computer byCount = (from comp in computers
                        where comp.count >= 30
                        select comp).FirstOrDefault();
Console.WriteLine("Компьютер в количестве не менее 30 штук:");
if (byCount != null)
{
    Console.WriteLine($"{byCount.markName} {byCount.count}");
}
class Computer
{
    public int code { get; set; }
    public string markName { get; set; }
    public string processor { get; set; }
    public double hzProcessor { get; set; }
    public int RAM { get; set; }
    public int ROM { get; set; }
    public int gpuMem { get; set; }
    public double price { get; set; }
    public int count { get; set; }
    public Computer(int code, string markName, string processor, double hzProcessor, int rAM, int rOM, int gpuMem, double price, int count)
    {
        this.code = code;
        this.markName = markName;
        this.processor = processor;
        this.hzProcessor = hzProcessor;
        RAM = rAM;
        ROM = rOM;
        this.gpuMem = gpuMem;
        this.price = price;
        this.count = count;
    }
}