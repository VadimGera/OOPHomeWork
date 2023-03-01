namespace OOPHomeWork;

public class Archer : Unit
{
    public int ShotDistance { get; init; }
    public int HpCurrent { get; init; }
    public int NumberOfArrows { get; init; }

    public override void Attack()
    {
        Console.WriteLine($"Archer shoots at: {ShotDistance}, HP: {HpCurrent}, Arrows: {NumberOfArrows}");
    }

    public override void Ability()
    {
        throw new NotImplementedException();
    }
}