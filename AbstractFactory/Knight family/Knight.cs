namespace AbstractFactory.Knight_family;

internal sealed class Knight : FighterBase
{
    public Knight()
    {
        Health = 50;
    }

    public override int Health { get; protected set; }
    
    public override void ArmWith(WeaponBase weapon)
    {
        if (weapon is not LongSword longSword)
        {
            throw new Exception("Knights can only fight with swords");
        }

        base.ArmWith(longSword);
    }
}