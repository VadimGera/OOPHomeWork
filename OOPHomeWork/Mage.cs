namespace OOPHomeWork;

public class Mage : Unit
{
    public int Mana { get; init; }
    public int Damage { get; init; }
    public int HpCurrent { get; init; }
    

    public override void Attack()
    {
        Console.WriteLine($"Mage attacks with staff: {Damage}, HP: {HpCurrent}, amount of mana {Mana}");
    }

    
    public int FireBall { get; init; }
    public override void Ability()
    {
        Console.WriteLine($"Mage Ability: FireBall: UP Attack Damage {FireBall}");
        Console.WriteLine();
    }
}