namespace OOPHomeWork;

public class Knight : Unit
{
    public int SwordDamage { get; init; }
    public int HpCurrent { get; init; }
    public int Armor { get; init; }

    public override void Attack()
    {
        Console.WriteLine($"Knight attacks sword: {SwordDamage}, HP Knight: {HpCurrent}, Armor: {Armor}");
    }

    public override void Ability()
    {
        throw new NotImplementedException();
    }
}