Console.Write("Введите числовой номер:");
BankAccount<int> account1 = new BankAccount<int>();
account1.Input();
Console.Write("Введите строчный номер:");
BankAccount<string> account2 = new BankAccount<string>();
account2.Input();
Console.WriteLine();
string infoAccount1 = account1.GetInfo();
string infoAccount2 = account2.GetInfo();
Console.WriteLine(infoAccount1 + infoAccount2);
Console.ReadKey();
class BankAccount<T>
{
    private T number;
    private double balance;
    private string PHYO;
    public void Input()
    {
        number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

        Console.Write("Введите ФИО:");
        PHYO = Console.ReadLine();
        Console.Write("Введите баланс:");
        balance = Convert.ToDouble(Console.ReadLine());
    }
    public string GetInfo()
    {
        return $"Номер:{number} ФИО:{PHYO} Баланс:{balance}\n";
    }
}