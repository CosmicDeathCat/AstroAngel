namespace Angel_Numbers;

public class NumberHandler
{
    public List<int> Numbers { get; set; }
    
    public NumberHandler()
    {
        Numbers = new List<int>{111, 222, 333, 444, 555, 666, 777, 888, 999};
    }
    
    public int GetNumber()
    {
        return Numbers[new Random().Next(0, Numbers.Count)];
    }
}