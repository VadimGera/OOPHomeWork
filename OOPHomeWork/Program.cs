using OOPHomeWork;

var knight = new Knight
{
    SwordDamage = 120,
    HpCurrent = 500,
    Armor = 10,
    UpArmor = 12
};

var archer = new Archer
{
    ShotDistance = 200,
    HpCurrent = 250,
    NumberOfArrows = 24,
    StreamOfArrows = 50
};

var mage = new Mage
{
    HpCurrent = 180,
    Mana = 280,
    Damage = 300,
    FireBall = 200
};


knight.Attack();
knight.Ability();

archer.Attack();
archer.Ability();

mage.Attack();
mage.Ability();



