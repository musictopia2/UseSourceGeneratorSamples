namespace FirstSimpleMappingSample;
public class ClassA
{
    public int Item1 { get; set; }
    public BasicList<int> FirstList { get; set; } = new();
    public BasicList<BasicList<int>> SecondList { get; set; } = new();
    public DateOnly DateUsed { get; set; }
    public string Item2 { get; set; } = "";
}