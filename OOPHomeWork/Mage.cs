namespace OOPHomeWork;

public class Mage : Unit
{
    public int AoE { get; set; }
    public override void Attack()
    {
        Console.WriteLine($"");
    }

    public override void Ability()
    {
        throw new NotImplementedException();
    }
}