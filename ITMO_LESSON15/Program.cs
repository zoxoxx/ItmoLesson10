Console.WriteLine("Арифметическая прогрессия:");
ArithProgression arith = new ArithProgression();
arith.SetStart(10);
arith.SetStep(2);
Console.WriteLine(arith.GetNext());
Console.WriteLine(arith.GetNext());
Console.WriteLine(arith.GetNext());
Console.WriteLine();
Console.WriteLine("Сброс к начальнаму значению.");
arith.Reset();
Console.WriteLine(arith.GetNext());
Console.WriteLine(arith.GetNext());
Console.WriteLine();
Console.WriteLine("Геометрическая прогрессия:");
GeomProgression geom = new GeomProgression();
geom.SetStart(10);
geom.SetStep(2);
Console.WriteLine(geom.GetNext());
Console.WriteLine(geom.GetNext());
Console.WriteLine(geom.GetNext());
Console.WriteLine();
Console.WriteLine("Сброс к начальнаму значению.");
geom.Reset();
Console.WriteLine(geom.GetNext());
Console.WriteLine(geom.GetNext());
Console.ReadKey();
public interface ISeries
{
    void SetStart(int x);
    int GetNext();
    void Reset();
}
public class ArithProgression : ISeries
{
    int step;
    int startValue;
    int currentValue;

    public int GetNext()
    {
        currentValue += step;
        return currentValue;
    }
    public void Reset()
    {
        currentValue = startValue;
    }
    public void SetStart(int x)
    {
        startValue = x;
        currentValue = startValue;
    }
    public void SetStep(int s) => step = s;
}

public class GeomProgression : ISeries
{
    int step;
    int startValue;
    int currentValue;

    public int GetNext()
    {
        currentValue *= step;
        return currentValue;
    }
    public void Reset()
    {
        currentValue = startValue;
    }
    public void SetStart(int x)
    {
        startValue = x;
        currentValue = startValue;
    }
    public void SetStep(int s) => step = s;
}