using System.Runtime.CompilerServices;

class SimpleDataBase<T>
{
   private  List<T> storedData  = new List<T>();
    private List<DateTime> inputDates = new List<DateTime>();
    public SimpleDataBase() {
        this.storedData = new List<T>() { };
    }
    public void AddNewData(T x)
    {
        this.storedData.Add(x);
        this.inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int i = 0;i<storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + 
                " berisi: " + this.storedData[i] +
                ", yang disimpan pada waktu UTC: " +
                this.inputDates[i]);
        }    
    }
}
public class Program
{
    public static void Main()
    {
        SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();
        simpleDataBase.AddNewData(13);
        simpleDataBase.AddNewData(02);
        simpleDataBase.AddNewData(21);
        simpleDataBase.PrintAllData();
    }

}
