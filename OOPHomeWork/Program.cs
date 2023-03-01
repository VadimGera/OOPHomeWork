using OOPHomeWork;

var knight = new Knight
{
    SwordDamage = 120,
    HpCurrent = 500,
    Armor = 10
};

var archer = new Archer
{
    ShotDistance = 200,
    HpCurrent = 250,
    NumberOfArrows = 24
};

var mage = new Mage
{
    AoE = 3334344,
};


knight.Attack();
archer.Attack();
mage.Attack();