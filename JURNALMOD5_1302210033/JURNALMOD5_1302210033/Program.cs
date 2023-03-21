// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<double> database = new SimpleDataBase<double>();
        database.AddNewData(1.3);
        database.AddNewData(0.2);
        database.AddNewData(2.1);
        database.PrintAllData();
    }
}

public class SimpleDataBase<T>
{
    List<T> storedData;
    List<DateTime> inputDates = new List<DateTime>();
    public SimpleDataBase()
    {
        storedData = new List<T>();
    }
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for(int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);

        }
    }
}


