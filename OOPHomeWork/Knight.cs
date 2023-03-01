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


    public int UpArmor { get; init; }

    public override void Ability()
    {
        Console.WriteLine($"Knight Ability : UP Armor {UpArmor}");
        Console.WriteLine();
    }
}